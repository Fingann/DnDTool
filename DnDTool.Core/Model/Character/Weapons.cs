using PropertyChanged;

namespace DnDTool.Core.Model.Character
{
    using System.Collections.Generic;
    [ImplementPropertyChanged]
    public class Weapons
    {
        public List<Weapon> AvailableWeapons { get; set; }

        public Weapon EquipedWeapons { get; set; } = new Weapon() {};


            
    }
}
