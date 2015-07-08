using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using Facebook;
using Domain;
using KwansemaRepublic.Support;

namespace KwansemaRepublic.Droid
{
    [Activity(Label = "Kwansema Republic", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
       

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(App.Instance);
            App.Instance.CorruptionSubmitted += (c) => OnCorruptionSubmitted(c);
            
        }

        private void OnCorruptionSubmitted(Corruption corruption)
        {
            FacebookClient client = new FacebookClient(StringSource.FaceBookAccessToken);
            client.PostTaskAsync(StringSource.FaceBookPage, new { message = corruption.Description });
        }
    }
}

