using RSSlibrary.Interfaces;
using RSSlibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSlibrary.Services
{
    public class XML_Repository : IRepository
    {
        public List<Beitrag> Download(string url)
        {
            throw new NotImplementedException();
        }

        public bool Favourite(Beitrag B)
        {
            throw new NotImplementedException();
        }

        public bool IsNotRead(bool status)
        {
            throw new NotImplementedException();
        }

        public bool IsRead(bool status)
        {
            throw new NotImplementedException();
        }

        public bool SaveFeed(Feed feed)
        {
            throw new NotImplementedException();
        }

        public bool SaveReadBeitrag(Beitrag B, bool status)
        {
            throw new NotImplementedException();
        }
    }
}
