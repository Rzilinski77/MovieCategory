using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie();
            List<Movie> movieList = new List<Movie>();

            movieList.Add(new Movie("Midsommar", "Horror"));
            movieList.Add(new Movie("Hereditary", "Horror"));
            movieList.Add(new Movie("The Grudge", "Horror"));
            movieList.Add(new Movie("Whisper of the Heart", "Animated"));
            movieList.Add(new Movie("My Neighbor Totoro", "Animated"));
            movieList.Add(new Movie("Nausicaa: Valley of the Wind", "Animated"));
            movieList.Add(new Movie("Sector 9", "Scifi"));
            movieList.Add(new Movie("Chappie", "Scifi"));
            movieList.Add(new Movie("Dirty Dancing", "Drama"));
            movieList.Add(new Movie("Memiors of a Geisha", "Drama"));

            Console.WriteLine("Welcome to the Movie List Application!\n");
            int numberOfMovies = movieList.Count;
            Console.WriteLine($"There are {numberOfMovies} movies in the list.");
            Console.WriteLine("What Category are you interested in? Horror(1), Animated(2), Scifi(3), Drama(4)");
            Console.Write("Enter a Number: ");
            string number = Console.ReadLine().ToLower();
            List<string> sortedList = movie.GetCategory(number, movieList);

            foreach (string title in sortedList)
            {
                Console.WriteLine(title);
            }

        }


    }
}
