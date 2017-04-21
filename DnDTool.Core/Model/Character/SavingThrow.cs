using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.Core.Model.Character
{
    using PropertyChanged;

    [ImplementPropertyChanged]
    public class SavingThrow
    {
        public string Name { get; set; }

        public int BaseScore { get; set; }

        public int ProficiencyScore { get; set; }

        public int TotalScore
        {
            get
            {
                if (Proficient)
                {
                    return BaseScore + this.ProficiencyScore;
                }
                return BaseScore;
            } 
        }

        public bool Proficient { get; set; } = true;

        public string URL { get; set; }
    }
}
