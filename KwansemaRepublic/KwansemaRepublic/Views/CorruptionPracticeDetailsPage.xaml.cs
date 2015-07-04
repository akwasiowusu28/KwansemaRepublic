using KwansemaRepublic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KwansemaRepublic.Views
{
    public partial class MyCorruptionPracticeLocationPage : ContentPage
    {
        private CorruptionPracticeDetailsViewModel _CorruptionPracticeLocationViewModel;

        public MyCorruptionPracticeLocationPage()
        {
            _CorruptionPracticeLocationViewModel = new CorruptionPracticeDetailsViewModel();
            BindingContext = _CorruptionPracticeLocationViewModel;
           
            InitializeComponent();
        }
    }

}
