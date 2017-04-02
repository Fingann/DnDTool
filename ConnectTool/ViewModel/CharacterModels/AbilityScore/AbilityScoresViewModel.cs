using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDTool.Model.Character;

namespace DnDTool.ViewModel.CharacterModels.AbilityScore
{
    public class AbilityScoresViewModel
    {
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
