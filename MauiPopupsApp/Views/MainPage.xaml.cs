using MauiPopupsApp.ViewModel;

namespace MauiPopupsApp.Views
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _vm;
        public MainPage()
        {
            InitializeComponent();

            _vm = new MainPageViewModel();
            BindingContext = _vm;
        }
    }

}
