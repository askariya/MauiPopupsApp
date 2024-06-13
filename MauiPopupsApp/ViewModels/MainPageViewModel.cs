using CommunityToolkit.Mvvm.Input;
using MauiPopupsApp.Views;

namespace MauiPopupsApp.ViewModel
{
    public partial class MainPageViewModel
    {
        public MainPageViewModel()
        {
        }

        [RelayCommand]
        public async Task DisplayMopup()
        {
            var fileData = await FilePicker.PickAsync();
        }

    }
}
