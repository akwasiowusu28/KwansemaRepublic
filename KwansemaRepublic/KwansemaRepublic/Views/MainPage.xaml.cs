using KwansemaRepublic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KwansemaRepublic.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainPageViewModel();
            InitializeComponent();
            SetupCorrputionListViewSelectionHandler();
        }

        private void SetupCorrputionListViewSelectionHandler()
        {
            
            CorruptionTypeList.ItemSelected += async (sender, e) =>
            {
                await Navigation.PushAsync(new MyCorruptionPracticeLocationPage());
            };
        }
    }
}
