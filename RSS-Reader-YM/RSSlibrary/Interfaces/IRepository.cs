using RSSlibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSlibrary.Interfaces
{
    public interface IRepository 
    {
        bool Download(string url);

        bool Save();

        List<Beitrag> Load();

        bool Favourite(Beitrag B);

        bool IsRead();

        



    }
}
