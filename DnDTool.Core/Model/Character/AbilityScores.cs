namespace DnDTool.Core.Model.Character
{
    using System.Collections.Generic;

    public class AbilityScores
    {
        public int ProficiencyBonus { get; set; } = 2;

        public int Inspiration { get; set; } = 0;

        public int PassiveWisdom { get; set; } = 0;

        public List<AbilityScore> Abilityscore { get; set; }= new List<AbilityScore>()
        {
            new AbilityScore() {Name = "Strength", ShortName = "STR"},
            new AbilityScore() {Name = "Dexterity", ShortName = "DEX"},
            new AbilityScore() {Name = "Constitution", ShortName = "CON"},
            new AbilityScore() {Name = "Intellegence", ShortName = "INT"},
            new AbilityScore() {Name = "Wisdom", ShortName = "WIS"},
            new AbilityScore() {Name = "Charisma", ShortName = "CHA"},

        };
    }
}
