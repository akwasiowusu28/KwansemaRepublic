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
using Android.Graphics.Drawables.Shapes;

[assembly: x.ExportRenderer(typeof(x.Entry), typeof(EntryFieldRenderer))]
namespace KwansemaRepublic.Droid.Renderers
{
    public class EntryFieldRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<x.Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetHintTextColor(Color.Gray);
                Control.Background = Resources.GetDrawable(global::Android.Resource.Drawable.EditText);
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

        public override void Draw(Canvas canvas)
        {
            Rect rectangle = new Rect();
            GetDrawingRect(rectangle);

            Paint paint = new Paint();
            paint.AntiAlias = true;
            paint.Color = Color.Gray;
            paint.SetStyle(Paint.Style.Stroke);
            canvas.DrawLine(rectangle.Left, rectangle.Bottom - 2, rectangle.Right, rectangle.Bottom, paint);

            paint.Dispose();

            base.Draw(canvas);
        }
    }
}