using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using Facebook;

namespace KwansemaRepublic.Droid
{
    [Activity(Label = "Kwansema Republic", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        private const string AppId = "799290236855997";
        private const string ExtendedPermissions = " publish_actions,publish_pages";
        private const int Login_Request_Code = 28;

        string accessToken;
        bool isLoggedIn;
        string lastMessageId;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            var webAuth = new Intent(this, typeof(FBWebViewAuthActivity));
            webAuth.PutExtra("AppId", AppId);
            webAuth.PutExtra("ExtendedPermissions", ExtendedPermissions);
            StartActivityForResult(webAuth, 28);

            LoadApplication(new App());
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (requestCode == Login_Request_Code && resultCode == Result.Ok)
            {
                String token = data.GetStringExtra("AccessToken");

                FacebookClient client = new FacebookClient(token);

                client.PostTaskAsync("1030146627004888/feed", new { message = "Step 1" });
            }
        }
    }
}

