namespace RSSlibrary.Models
{
    public class Beitrag
    {
        public Guid BeitragID { get; set; }

        public string Link { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime PubDate { get; set; }


    }
}