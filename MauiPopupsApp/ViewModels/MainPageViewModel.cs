using CommunityToolkit.Mvvm.Input;
using MauiPopupsApp.Views;
using Mopups.PreBaked.PopupPages.DualResponse;

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
            var result = await DualResponseViewModel.AutoGenerateBasicPopup(Colors.WhiteSmoke, 
                Colors.Red, 
                "Okay", 
                Colors.WhiteSmoke, 
                Colors.Green, 
                "Looks Good!", 
                Colors.DimGray, 
                "This is an example of a dual response popup page", "thumbsup.png");
        }

    }
}
