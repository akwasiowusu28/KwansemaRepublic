using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KwansemaRepublic.Controls
{
    public class CheckBox: Button
    {
        public static readonly BindableProperty IsCheckedProperty =
             BindableProperty.Create<CheckBox, bool>(p => p.IsChecked, true);

        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }
        public CheckBox():base() {}
    }
}
