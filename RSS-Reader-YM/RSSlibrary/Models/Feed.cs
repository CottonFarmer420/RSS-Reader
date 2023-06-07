using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSlibrary.Models
{
    public class Feed
    {
        public string FeedID { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Link { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public Beitrag B { get; set; }

        public Feed(string title, string FeedID, string link) 
        { 
            this.FeedID = Guid.NewGuid().ToString();
            this.Title = title;
            this.FeedID = FeedID;
            this.Link = link;
            this.B = new Beitrag();
        }


        
    }
}
