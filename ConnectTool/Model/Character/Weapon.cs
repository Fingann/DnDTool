using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.Model.Character
{
    public class Damage
    {
    
        public int dice_count { get; set; }

      
        public int dice_value { get; set; }

        public DamageType damage_type { get; set; }
    }

    public class Weapon
    {
        public String Name { get; set; }
    }

}
