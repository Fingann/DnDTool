namespace DnDTool.Core.Model.Character
{
    using System.Collections.Generic;

    public class Weapons
    {
        public List<Weapon> AvailableWeapons { get; set; }

        public Weapon EquipedWeapon { get; set; } = new Weapon() {};


            
    }
}
