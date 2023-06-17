using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RSSLibrary.Interfaces;
using RSSLibrary.Models;
using RSSLibrary.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_MAUI.ViewModels
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

        [RelayCommand]
        void Save(string url)
        {
            url = this.url;

            List<Beitrag> daten = _repository.Download(url);

            foreach (var item in daten)
            {
                this.Gespeicherte.Add(item);
                Debug.WriteLine(item);
            }
        }

    }
}
