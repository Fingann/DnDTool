using PropertyChanged;

namespace DnDTool.Core.Model.Character
{
    using System;
    [ImplementPropertyChanged]
    public class Damage
    {
    
        public int dice_count { get; set; }

      
        public int dice_value { get; set; }

        //DatamageType
        public string damage_type { get; set; }
    }
    [ImplementPropertyChanged]
    public class Weapon
    {
        public String Name { get; set; }
    }

}
