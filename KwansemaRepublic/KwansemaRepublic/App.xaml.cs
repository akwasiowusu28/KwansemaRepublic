using Domain;
using KwansemaRepublic.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KwansemaRepublic
{
    public partial class App : Application
    {
        private static object SyncLock = new object();
        private static volatile App _Instance;
       
        private App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }


        public static App Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (SyncLock)
                    {
                        if (_Instance == null)
                            _Instance =  new App();
                    }
                }

                return _Instance;
            }
        }

        public Action<Corruption> CorruptionSubmitted;
    }
}
