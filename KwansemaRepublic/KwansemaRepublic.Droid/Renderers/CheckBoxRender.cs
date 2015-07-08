using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using x = Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using KwansemaRepublic.Droid.Renderers;
using Xamarin.Forms;

[assembly: x.ExportRenderer(typeof(KwansemaRepublic.Controls.CheckBox), typeof(CheckBoxRender))]
namespace KwansemaRepublic.Droid.Renderers
{
   
    public class CheckBoxRender: ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<x.Button> e)
        {
            var androidCheckBox = new Android.Widget.CheckBox(this.Context);
            this.SetNativeControl(androidCheckBox);
            base.OnElementChanged(e);
            
        }
    }
}