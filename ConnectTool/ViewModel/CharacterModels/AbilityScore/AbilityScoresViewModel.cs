using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.ViewModel.CharacterModels.AbilityScore
{
    using DnDTool.Core.Model.Character;

    using GalaSoft.MvvmLight.Ioc;

    public class AbilityScoresViewModel
    {
        [PreferredConstructor]
        public AbilityScoresViewModel()
        {
            
        }

        public AbilityScoresViewModel(AbilityScores abilityScores)
        {
            AbilityScores = abilityScores;
        }
        public AbilityScores AbilityScores { get; set; }
    }
}
