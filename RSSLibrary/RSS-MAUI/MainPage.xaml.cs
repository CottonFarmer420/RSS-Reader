using RSS_MAUI.ViewModels;

namespace RSS_MAUI
{
    public partial class MainPage : ContentPage
    {


        public MainPage(MainViewModel mainviewmodel)
        {
            InitializeComponent();
            this.BindingContext = mainviewmodel;
        }

    }
}