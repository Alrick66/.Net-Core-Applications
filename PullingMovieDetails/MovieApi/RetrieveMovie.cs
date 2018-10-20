namespace MovieApi
{
    using System.Collections.Generic;
    using System.Net;
    using Newtonsoft.Json;
    public class RetrieveMovie
    {
        public Movie  getMovie(string movieName)
        {
            JsonSerializer serializer = new JsonSerializer();
            Movie movie = new Movie();
            string url1 = "http://www.omdbapi.com/?t=" + movieName + "&apikey=867d7138";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url1);               
                movie = JsonConvert.DeserializeObject<Movie>(json);
                if (movie.Response == "True")
                {
                    return movie;
                }
            }
            return null;
        }
        public List<Movie>  getMovies(List<string> movieName)
        {
            List<Movie> movies = new List<Movie>();
            JsonSerializer serializer = new JsonSerializer();
            Movie movie = new Movie();
            foreach (var name in movieName)
            {
                string url1 = "http://www.omdbapi.com/?t=" + name + "&apikey=867d7138";
                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString(url1);
                    movie = JsonConvert.DeserializeObject<Movie>(json);
                    if (movie.Response == "True")
                    {
                        movies.Add(movie);
                    }
                }
            }
            return movies;
        }
    }
}
