using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSlibrary.Models
{
    public class Feed
    {

        public string Title { get; set; } = string.Empty;

        public string URL { get; set; } = string.Empty;

        public Feed(string title, string description, string url) 
        { 
            this.Title = title;
            this.URL = url;
        }


        
    }
}
