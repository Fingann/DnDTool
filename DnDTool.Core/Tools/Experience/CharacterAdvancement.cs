namespace DnDTool.Core.Tools.Experience
{
    internal struct CharacterAdvancement
    {
        
        public CharacterAdvancement(int experience, int level, int proficiencyBonus)
        {
            this.Experience = experience;
            this.Level = level;
            this.ProficiencyBonus = proficiencyBonus;
        }

        public int Experience { get; set; }

        public int Level { get; set; }

        public int ProficiencyBonus { get; set; }
    }
}
