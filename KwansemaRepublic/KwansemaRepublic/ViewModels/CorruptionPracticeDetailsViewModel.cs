using Domain;
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
    public class CorruptionPracticeDetailsViewModel
    {
        #region Labels
        public string OtherLocationLabel { get { return StringSource.OtherLocationLabel; } }
        public string DescriptionLabel { get { return StringSource.DescriptionLabel; } }
        public string EvidenceLabel { get { return StringSource.EvidenceLabel; } }
        public string VideoLabel { get { return StringSource.VideoLabel; } }
        public string AudioLabel { get { return StringSource.AudioLabel; } }
        public string GalleryLabel { get { return StringSource.GalleryLabel; } }
        public string HonorCodeLabel { get { return StringSource.HonorCodeLabel; } }
        public string HonorCode { get { return StringSource.HonorCode; } }
        public string Submit { get { return StringSource.Submit; } }
        #endregion

        #region Methods
        private void Submit()
        {
            if (App.Instance.CorruptionSubmitted != null)
            {
                var location = new Location("");
                var videoPath = "";
                var audioPath = "";
                var imagePath = "";
                var description = "";

                Corruption corruption = new Corruption { Location = location, Description = description, 
                                                         AudioPath = audioPath, VideoPath = videoPath, ImagePath = imagePath};

                App.Instance.CorruptionSubmitted(corruption);
            }
        }
        #endregion


    }
}
