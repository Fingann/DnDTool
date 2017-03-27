using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.Model.Character
{
    public class Character
    {
        public Character()
        {
            
        }
       public Info Info { get; set; }

        public AbilityScores AbilityScores { get; set; }

        public Skills Skills { get; set; }

        public Traits Traits { get; set;  }






    }
}
