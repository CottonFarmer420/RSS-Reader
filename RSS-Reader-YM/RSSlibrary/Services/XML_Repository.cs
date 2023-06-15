using RSSlibrary.Interfaces;
using RSSlibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Xml.Linq;

namespace RSSlibrary.Services
{
    public class XML_Repository : IRepository
    {
        public List<Beitrag> Download(string url)
        {
            var rssFeedXml = XDocument.Load(url);

            var list = from descendant in rssFeedXml.Descendants("item")
                       select new Beitrag
                       {
                           URL = descendant.Element("link").Value,
                           Title = descendant.Element("title").Value,
                           Description = descendant.Element("description").Value,
                           PubDate = descendant.Element("pubDate").Value,                        
                       };

            
           

            return list.ToList();
        }

        public bool Favourite(Beitrag B)
        {
            return true;
        }

        public bool IsNotRead(bool status)
        {
            return status = false;
        }

        public bool IsRead(bool status)
        {
            return status = true;
        }

        public bool SaveFeed(Feed feed)
        {
            return true;
        }

        public bool SaveReadBeitrag(Beitrag B, bool status)
        {
            return true;
        }
    }
}
