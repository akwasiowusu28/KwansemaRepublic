//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KwansemaRepublic.Views {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class MyCorruptionPracticeLocationPage : ContentPage {
        
        private Entry CityEntry;
        
        private Editor DescriptionEditor;
        
        private Button Video;
        
        private Button Audio;
        
        private Button Gallery;
        
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(MyCorruptionPracticeLocationPage));
            CityEntry = this.FindByName<Entry>("CityEntry");
            DescriptionEditor = this.FindByName<Editor>("DescriptionEditor");
            Video = this.FindByName<Button>("Video");
            Audio = this.FindByName<Button>("Audio");
            Gallery = this.FindByName<Button>("Gallery");
        }
    }
}
