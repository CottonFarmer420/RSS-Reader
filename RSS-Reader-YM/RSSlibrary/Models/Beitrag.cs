namespace RSSlibrary.Models
{
    public class Beitrag
    {
        public string URL { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string PubDate { get; set; } = string.Empty;

        public bool Status { get; set; } = false;

        public Beitrag(string url, string title, string description, string PubDate, bool status)
        {
            this.URL = url;
            this.Title = title;
            this.Description = description;
            this.PubDate = PubDate;
            this.Status = status;
        }


    }
}