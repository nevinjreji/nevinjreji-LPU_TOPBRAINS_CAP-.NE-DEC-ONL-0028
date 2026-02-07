using System;
using MovieStack;

class Program
{
    public static List<Movie> movieList = new List<Movie>();
    public static void Main()
    {

        System.Console.WriteLine("Enter how many movies do you want to add : ");
        int numOfMovies = Convert.ToInt32(Console.ReadLine());

        Movie movieObj = new Movie();

        for (int i = 0; i < numOfMovies; i++)
        {
            string movieDetails = Console.ReadLine();
            movieObj.AddMovie(movieDetails);
        }

        System.Console.Write("Enter the movie genre to search : ");
        string searchGenre = Console.ReadLine();

        List<Movie> genreList = new List<Movie>();
        genreList = movieObj.ViewMoviesByGenre(searchGenre);
        foreach (var item in genreList)
        {
            System.Console.WriteLine($"{item.Title} {item.Artist} {item.Genre} {item.Ratings}");
        }

        List<Movie> sortedList = new List<Movie>();
        sortedList = movieObj.ViewMoviesByRatings();

        foreach (var item in sortedList)
        {
            System.Console.WriteLine($"{item.Title} {item.Artist} {item.Genre} {item.Ratings}");
        }
    }
}