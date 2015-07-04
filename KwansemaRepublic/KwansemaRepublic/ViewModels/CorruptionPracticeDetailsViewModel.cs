using KwansemaRepublic.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KwansemaRepublic.ViewModels
{
    public class CorruptionPracticeDetailsViewModel: INotifyPropertyChanged
    {
        private class LocalConstants
        {
           
        }
        
        public List<string> Regions { get; set; }
        public String OtherLocationLabel { get { return StringSource.OtherLocationLabel; } }
        public String DescriptionLabel { get { return StringSource.DescriptionLabel; } }
        public String EvidenceLabel { get { return StringSource.EvidenceLabel; } }
        public String VideoLabel { get { return StringSource.VideoLabel; } }
        public String AudioLabel { get { return StringSource.AudioLabel; } }
        public String GalleryLabel { get { return StringSource.GalleryLabel; } }

        private int _SelectedRegion;
        public int SelectedRegion
        {
            get { 
                return _SelectedRegion;
            }
            set
            {
                _SelectedRegion = value;
                NotifyPropertyChanged();
            }
        }

        private string _City;
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                _City = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName]String propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
