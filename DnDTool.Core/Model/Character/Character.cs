namespace DnDTool.Core.Model.Character
{
    using System;
    using System.Collections.Generic;

    public class Character
    {
       
        public Info Info { get; set; }

        public AbilityScores AbilityScores { get; set; } 

        public Skills Skills { get; set; }

        public Traits Traits { get; set;  }
        public Weapons Weapons { get; set; }

    }
}
