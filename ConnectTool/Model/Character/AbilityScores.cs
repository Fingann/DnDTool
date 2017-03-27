using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.Model.Character
{
    public class AbilityScores
    {
        public int ProficiencyBonus { get; set; }

        public int Inspiration { get; set; }
        public int PassiveWisdom { get; set; }

        public List<AbilityScore> Abilityscore { get; set; }
    }
}
