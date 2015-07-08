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
using KwansemaRepublic.Droid.Renderers;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using Android.Graphics.Drawables;

[assembly: x.ExportRenderer(typeof(x.Editor), typeof(EditorFieldRenderer))]
namespace KwansemaRepublic.Droid.Renderers
{
    public class EditorFieldRenderer: EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<x.Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetHintTextColor(Color.Gray);
                Control.Background = Resources.GetDrawable(global::Android.Resource.Drawable.EditBoxBackgroundNormal);
                Control.SetTextColor(Color.DarkGray);
            }
        }

       

        private ShapeDrawable GetBackground()
        {
            var shapeDrawable = new ShapeDrawable();
            shapeDrawable.Paint.SetStyle(Paint.Style.Stroke);
            shapeDrawable.Paint.Color = Color.Gray;
            shapeDrawable.Paint.StrokeWidth = 6;

            return shapeDrawable;
        }
    }
}