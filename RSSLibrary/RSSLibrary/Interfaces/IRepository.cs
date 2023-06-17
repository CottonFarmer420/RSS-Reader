using RSSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSLibrary.Interfaces
{
    public interface IRepository
    {
        bool SaveFeed(Feed feed);

        List<Beitrag> Download(string url);

        bool Favourite(Beitrag B);

        bool IsRead(bool status);

        bool IsNotRead(bool status);

        bool SaveReadBeitrag(Beitrag B, bool status);

        //Feed löschen links

    }
}
