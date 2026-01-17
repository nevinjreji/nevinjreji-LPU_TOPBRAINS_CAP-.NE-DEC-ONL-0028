using System;
using System.Collections.Generic;

namespace MovieStack
{
    class Movie
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Ratings { get; set; }

        public static List<Movie> movieList = new List<Movie>();

        public void AddMovie(string movieDetails)
        {
            string[] data = movieDetails.Split(',');

            Movie movieObj = new Movie{
            Title = data[0],
            Artist = data[1],
            Genre = data[2],
            Ratings = Int32.Parse(data[3])
            };

            movieList.Add(movieObj);
        }

        public List<Movie> ViewMoviesByGenre(string genre)
        {
            List<Movie> GenreMovies = new List<Movie>();

            foreach (var item in movieList)
            {
                if (item.Genre == genre)
                {
                    GenreMovies.Add(item);
                }
            }

            return GenreMovies;
        }
        public List<Movie> ViewMoviesByRatings()
        {
            return movieList.OrderByDescending(m => m.Ratings).ToList();
        }
    }
}