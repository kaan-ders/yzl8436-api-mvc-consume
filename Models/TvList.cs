namespace MvcApiConsume.Models
{
    public class TvList
    {
        public int page { get; set; }
        public List<Tv> results { get; set; } = new();
    }

    public class Tv
    {
        public int id { get; set; }
        public string name { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }
    }

    public class TvDetail : Tv
    {
        public DateTime last_air_date { get; set; }
        public int number_of_episodes { get; set; }
        public int number_of_seasons { get; set; }
        public List<Cast> Cast { get; set; } = new();
    }
}