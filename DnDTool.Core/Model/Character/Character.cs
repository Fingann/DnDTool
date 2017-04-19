using DnDTool.Core.Strategy;

namespace DnDTool.Core.Model.Character
{
    using System;
    using System.Collections.Generic;

    public class Character
    {
       
        public Info Info { get; set; } = new Info();

        public AbilityScores AbilityScores { get; set; } =new AbilityScores();

        public Skills Skills { get; set; } = new Skills();

        public Traits Traits { get; set;  } = new Traits(); 
        public Weapons Weapons { get; set; }= new Weapons();

       

    }
}
