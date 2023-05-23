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

        public string title { get; set; } = string.Empty;

        public string link { get; set; } = string.Empty;

        public string description { get; set; } = string.Empty;

        public Beitrag b { get; set; }

        public Feed(string title, string FeedID, string link) 
        { 
            this.FeedID = Guid.NewGuid().ToString();
            this.title = title;
            this.FeedID = FeedID;
            this.link = link;
            this.b = new Beitrag();
        }



    }
}
