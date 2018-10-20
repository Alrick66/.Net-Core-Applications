namespace DisplayDetails
{
    using System;
    using System.Collections.Generic;
    using MovieApi;

    class Program
    {
        public static void Main(string[] args)
        {
            ////Details of single movies
            //singleMovieDisplay();

            //Details of multiple movies
            multipleMovieDisplay();

            Console.ReadKey();
        }

        public static void singleMovieDisplay()
        {
            Movie movie = new Movie();
            RetrieveMovie getMovie = new RetrieveMovie();

            movie = getMovie.getMovie("Deadpool");

            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("Name =   " + movie.Title + " \n" +
                                "Caption =   " + movie.Plot + " \n" +
                                "Image =   " + movie.Poster + " \n" +
                                "Trailer =   " + movie.TrailerUrl);
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        }

        public static void multipleMovieDisplay()
        {
            RetrieveMovie getMovie = new RetrieveMovie();
            List<Movie> movies = new List<Movie>();

            movies = getMovie.getMovies(new List<string> { "Deadpool", "Safe", "Safe House" });
            foreach (var movie in movies)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("Name =   " + movie.Title + " \n" +
                                    "Caption =   " + movie.Plot + " \n" +
                                    "Image =   " + movie.Poster + " \n" +
                                    "Trailer =   " + movie.TrailerUrl);
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            }
        }
    }
}