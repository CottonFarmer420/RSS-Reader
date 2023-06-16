
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSSlibrary.Interfaces;
using RSSlibrary.Models;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        IRepository _repository;

        [ObservableProperty]
        ObservableCollection<Beitrag> _gespeicherte = new ObservableCollection<Beitrag>();

        public MainViewModel(IRepository repository)
        {
            this._repository = repository;
        }

        [ObservableProperty]
        string title = "";

        [ObservableProperty]
        string description = "";

        [ObservableProperty]
        string url = "";

        [ObservableProperty]
        string pubDate = "";

        [ObservableProperty]
        string status = "";

        [ObservableProperty]
        string feedtitle = "";

        [ObservableProperty]
        string feedURL = "";



    }
}
