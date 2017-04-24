using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDTool.Core.Resources.Characters
{
    public static class Races
    {
        public static List<string> PlayableRace { get; set; } = new List<string>()
        {
            "Dragonborn",
            "Dwarf",
            "Elf",
            "Gnome",
            "Half-Elf",
            "Half-Orc",
            "Halfling",
            "Human",
            "Tiefling"
        };
    }
}