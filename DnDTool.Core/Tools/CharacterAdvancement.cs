namespace DnDTool.Core.Tools
{
    struct CharacterAdvancement
    {
        
        public CharacterAdvancement(int experiance, int level, int proficiencyBonus)
        {
            Experiance = experiance;
            Level = level;
            ProficiencyBonus = proficiencyBonus;
        }

        public int Experiance { get; set; }
        public int Level { get; set; }
        public int ProficiencyBonus { get; set; }
    }
}
