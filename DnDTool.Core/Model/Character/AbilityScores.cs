namespace DnDTool.Core.Model.Character
{
    using System.Collections.Generic;

    public class AbilityScores
    {
        public int ProficiencyBonus { get; set; } = 2;

        public int Inspiration { get; set; } = 0;

        public int PassiveWisdom { get; set; } = 0;

        public List<AbilityScore> Abilityscore { get; set; } = new List<AbilityScore>() { new AbilityScore(), new AbilityScore(), new AbilityScore(), new AbilityScore(), new AbilityScore(), new AbilityScore() };
    }
}
