using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.Core.Model.Character
{
    public class SavingThrow
    {
        public string Name { get; set; }

        public int Score { get; set; }

        public int Bonus { get; set; }

        public bool Proficient { get; set; }

        public string URL { get; set; }
    }
}
