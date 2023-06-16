using RSSlibrary.Interfaces;
using RSSlibrary.Services;
using RSSlibrary;
using RSSlibrary.Models;
using System.Net;

IRepository repository = new XML_Repository();

Console.WriteLine("Gib dein Link ein:");
string url = Console.ReadLine();

List<Beitrag> ausgabe = repository.Download(url);

foreach (var item in ausgabe)
{
    
    Console.WriteLine(item.Title);
    Console.WriteLine(item.Description);
    Console.WriteLine(item.URL);
    Console.WriteLine(item.PubDate);
}





