namespace MvcApiConsume.Models
{
    public class MovieList
    {
        public int page { get; set; }
        public List<Movie> results { get; set; } = new();
    }

    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }
    }

    public class MovieDetail : Movie
    {
        public string imdb_id { get; set; }
        public DateTime release_date { get; set; }
        public int runtime { get; set; }
        public List<Cast> Cast { get; set; } = new();
    }
}
