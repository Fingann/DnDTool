using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.ViewModel.CharacterModels.AbilityScore
{
    using DnDTool.Core.Model.Character;
    using DnDTool.Model.Messages;

    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Ioc;
    using GalaSoft.MvvmLight.Messaging;

    public class AbilityScoresViewModel: ViewModelBase
    {
        private AbilityScores abilityScores;

        public AbilityScoresViewModel()
        {
         
        }

        public AbilityScores AbilityScores
        {
            get
            {
                return this.abilityScores;
            }
            set
            {
                this.abilityScores = value;
                this.RaisePropertyChanged();
            }
        }
    }
}
