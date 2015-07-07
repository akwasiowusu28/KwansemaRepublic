using KwansemaRepublic.Support;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KwansemaRepublic.ViewModels
{
    public class MainPageViewModel
    {

        public MainPageViewModel()
        {
            TopLevelText = StringSource.MainPageTopLevelText;
            BuildCorruptionTypesList();
        }

        public string TopLevelText { get; set; }
        public List<CorruptionTypeViewModel> CorruptionTypes { get; set; }

        private void BuildCorruptionTypesList()
        {
            CorruptionTypes = new List<CorruptionTypeViewModel>()
            {
                new CorruptionTypeViewModel(){
                    CorruptionTypeIcon = _CorruptionTypeIconPair[CorruptionTypeEnums.FRAUD], 
                    CorruptionType = new CorruptionType(){TypeName = StringSource.Fraud, TypeDescription=StringSource.FraudDescription}},

                new CorruptionTypeViewModel(){
                    CorruptionTypeIcon = _CorruptionTypeIconPair[CorruptionTypeEnums.BRIBERY], 
                    CorruptionType = new CorruptionType(){TypeName = StringSource.Bribery, TypeDescription=StringSource.BriberyDescription}},

                new CorruptionTypeViewModel(){
                    CorruptionTypeIcon = _CorruptionTypeIconPair[CorruptionTypeEnums.ABUSE], 
                    CorruptionType = new CorruptionType(){TypeName = StringSource.AbuseOfPower, TypeDescription=StringSource.AbuseDescription}},

                new CorruptionTypeViewModel(){
                    CorruptionTypeIcon = _CorruptionTypeIconPair[CorruptionTypeEnums.WASTE], 
                    CorruptionType = new CorruptionType(){TypeName = StringSource.WasteOfPublicResource, TypeDescription=StringSource.WasteDescription}},

                new CorruptionTypeViewModel(){
                    CorruptionTypeIcon = _CorruptionTypeIconPair[CorruptionTypeEnums.EXTORTION],
                    CorruptionType = new CorruptionType(){TypeName =StringSource.Extortion, TypeDescription=StringSource.ExtortionDescription}},

                new CorruptionTypeViewModel(){
                    CorruptionTypeIcon = _CorruptionTypeIconPair[CorruptionTypeEnums.EMBEZZLEMENT],
                    CorruptionType = new CorruptionType(){TypeName = StringSource.Embezzlement, TypeDescription=StringSource.EmbezzlementDescription}},

                new CorruptionTypeViewModel(){
                    CorruptionTypeIcon = _CorruptionTypeIconPair[CorruptionTypeEnums.FAVORATISM],
                    CorruptionType = new CorruptionType(){TypeName = StringSource.FravoratismNepotismClientelism, TypeDescription=StringSource.FravoratismNCDescription}}
            };
        }

        private Dictionary<CorruptionTypeEnums, ImageSource> _CorruptionTypeIconPair = new Dictionary<CorruptionTypeEnums, ImageSource>()
        {
            {CorruptionTypeEnums.FRAUD, ImageSource.FromResource(StringSource.FraudImage)},
            {CorruptionTypeEnums.BRIBERY, ImageSource.FromResource(StringSource.BriberyImage)},
            {CorruptionTypeEnums.ABUSE, ImageSource.FromResource(StringSource.AbuseImage)},
            {CorruptionTypeEnums.WASTE, ImageSource.FromResource(StringSource.WasteImage)},
            {CorruptionTypeEnums.EXTORTION, ImageSource.FromResource(StringSource.ExtortionImage)},
            {CorruptionTypeEnums.EMBEZZLEMENT, ImageSource.FromResource(StringSource.EmbezzlementImage)},
            {CorruptionTypeEnums.FAVORATISM, ImageSource.FromResource(StringSource.favoratismNCImage)},
        };

        private enum CorruptionTypeEnums
        {
            FRAUD, BRIBERY, ABUSE, WASTE, EXTORTION, EMBEZZLEMENT, FAVORATISM
        }
    }
}
