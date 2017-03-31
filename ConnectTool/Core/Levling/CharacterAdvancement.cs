using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.Core.Levling
{
    class CharacterAdvancement
    {
        public CharacterAdvancement(int experiance, int level, int proficiencyBonus)
        {
            Experiance = experiance;
            Level = level;
            ProficiencyBonus = proficiencyBonus;
        }

        public int Experiance { get; set; }
        public int Level { get; set; }
        public int ProficiencyBonus { get; set; }
    }
}
