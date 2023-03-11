namespace MvcApiConsume.Models
{
    public class CastList
    {
        public List<Cast> cast { get; set; } = new();
    }

    public class Cast
    {
        public string name { get; set; }
        public string character { get; set; }
        public string profile_path { get; set; }
    }
}
