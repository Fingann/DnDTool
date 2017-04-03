namespace DnDTool.Core.Model.Character
{
    using System.Collections.Generic;

    public class AbilityScores
    {
        public int ProficiencyBonus { get; set; }

        public int Inspiration { get; set; }
        public int PassiveWisdom { get; set; }

        public List<AbilityScore> Abilityscore { get; set; } = new List<AbilityScore>() { new AbilityScore(), new AbilityScore(), new AbilityScore(), new AbilityScore(), new AbilityScore(), new AbilityScore() };
    }
}
