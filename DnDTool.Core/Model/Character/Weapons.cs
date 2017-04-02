using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.Model.Character
{
    public class Weapons
    {
        public List<Weapon> AvailableWeapons { get; set; }

        public Weapon EquipedWeapon { get; set; } = new Weapon() {};


            
    }
}
