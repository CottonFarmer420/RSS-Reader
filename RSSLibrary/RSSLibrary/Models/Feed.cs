using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSLibrary.Models
{
    public class Feed
    {

        public string FeedTitle { get; set; } = string.Empty;

        public string FeedURL { get; set; } = string.Empty;

        public Feed(string feedtitle, string description, string feedurl)
        {
            this.FeedTitle = feedtitle;
            this.FeedURL = feedurl;
        }

        public Feed()
        {

        }

    }
}
