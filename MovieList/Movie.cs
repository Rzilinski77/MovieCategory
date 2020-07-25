using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MovieList
{
    class Movie
    {
        private string Title { get; set; }
        private string Category { get; set; }

        public Movie() { }
        public Movie (string title, string category)
        {
            Title = title;
            Category = category;
        }

        public List<string> GetCategory(string number, List<Movie> movieList)
        {
            List<string> sortedList = new List<string>();
            bool again = true;

            while (again == true)
            {
                if (number == "1" || number == "one")
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == "Horror")
                        {
                            sortedList.Add(movie.Title);
                            again = false;
                        }
                    }
                }
                else if (number == "2" || number == "two")
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == "Animated")
                        {
                            sortedList.Add(movie.Title);
                            again = false;
                        }
                    }
                }
                else if (number == "3" || number == "three")
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == "Scifi")
                        {
                            sortedList.Add(movie.Title);
                            again = false;
                        }
                    }
                }
                else if (number == "4" || number == "four")
                {
                    foreach (Movie movie in movieList)
                    {
                        if (movie.Category == "Drama")
                        {
                            sortedList.Add(movie.Title);
                            again = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid entry, please try again");
                    Console.WriteLine("What Category are you interested in? Horror(1), Animated(2), Scifi(3), Drama(4)");
                    Console.Write("Enter a Number: ");
                    number = Console.ReadLine().ToLower();
                }
            }


            sortedList.Sort();
            return sortedList;

        }


    }
}
