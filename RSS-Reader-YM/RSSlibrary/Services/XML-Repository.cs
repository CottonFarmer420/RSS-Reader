using RSSlibrary.Interfaces;
using RSSlibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSlibrary.Services
{
    public class XML_Repository : IRepository
    {
        public bool Download(string url)
        {
            //Hineinladen von Beiträgen
            throw new NotImplementedException();
        }

        public bool Favourite(Beitrag B)
        {
            //Beitrag favorisieren können
            throw new NotImplementedException();
        }

        public bool IsRead()
        {
            //Beitrag schon gelesen worden?
            throw new NotImplementedException();
        }

        public List<Beitrag> Load()
        {   
            //Laden von Beiträgen auch jene welche schon gelesen wurden
            throw new NotImplementedException();
        }

        public bool Save()
        {
            //Beiträge Speichern in externer Datei
            throw new NotImplementedException();
        }
    }
}
