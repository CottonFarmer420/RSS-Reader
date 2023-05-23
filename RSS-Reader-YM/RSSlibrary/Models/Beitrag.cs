namespace RSSlibrary.Models
{
    public class Beitrag
    {
        public Guid BeitragID { get; set; }

        public string link { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public DateTime pubDate { get; set; }


    }
}