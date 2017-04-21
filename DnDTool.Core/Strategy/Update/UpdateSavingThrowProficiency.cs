using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.Core.Strategy.Update
{
    using DnDTool.Core.Model.Character;
    using DnDTool.Core.Tools.Experience;

    class UpdateSavingThrowProficiency : UpdateStrategy
    {
        public override void Update(Character charecter)
        {

            foreach (var charecterAbilityScores in charecter.AbilityScores.Abilityscore)
            {
                foreach (var savingThrow in charecterAbilityScores.SavingThrows)
                {
                    savingThrow.BaseScore = charecterAbilityScores.Bonus;
                    savingThrow.ProficiencyScore = charecter.AbilityScores.ProficiencyBonus;
                }
            }
            
        }
    }
}
