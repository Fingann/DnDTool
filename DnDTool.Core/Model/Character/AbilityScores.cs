namespace DnDTool.Core.Model.Character
{
    using System.Collections.Generic;
    using System.ComponentModel;

    using PropertyChanged;

    [ImplementPropertyChanged]
    public class AbilityScores
    {
        public int ProficiencyBonus { get; set; } = 2;

        public int Inspiration { get; set; } = 0;

        public int PassiveWisdom { get; set; } = 0;

        public List<AbilityScore> Abilityscore { get; set; }= new List<AbilityScore>()
        {
            new AbilityScore() {Name = "Strength", ShortName = "STR", SavingThrows = new BindingList<SavingThrow>()
                                                                                         {
                                                                                             new SavingThrow() {Name = "STR Saving Throw", Score = 0},
                                                                                             new SavingThrow() {Name = "Athletics", Score = 0}
                                                                                         } },
            new AbilityScore() {Name = "Dexterity", ShortName = "DEX",SavingThrows = new BindingList<SavingThrow>()
                                                                                         {
                                                                                             new SavingThrow() {Name = "DEX Saving Throw", Score = 0},
                                                                                             new SavingThrow() {Name = "Acrobatics", Score = 0},
                                                                                              new SavingThrow() {Name = "Slight Of Hand", Score = 0},
                                                                                               new SavingThrow() {Name = "Stealth", Score = 0},
                                                                                         } },
            new AbilityScore() {Name = "Constitution", ShortName = "CON", SavingThrows = new BindingList<SavingThrow>()
                                                                                         {
                                                                                             new SavingThrow() {Name = "CON Saving Throw", Score = 0}
                                                                                             
                                                                                         } },
            new AbilityScore() {Name = "Intellegence", ShortName = "INT",SavingThrows = new BindingList<SavingThrow>()
                                                                                         {
                                                                                             new SavingThrow() {Name = "INT Saving Throw", Score = 0},
                                                                                             new SavingThrow() {Name = "Arcana", Score = 0},
                                                                                              new SavingThrow() {Name = "History", Score = 0},
                                                                                               new SavingThrow() {Name = "Investigation", Score = 0},
                                                                                                new SavingThrow() {Name = "Nature", Score = 0},
                                                                                                 new SavingThrow() {Name = "Religion", Score = 0},
                                                                                         } },
            new AbilityScore() {Name = "Wisdom", ShortName = "WIS",SavingThrows = new BindingList<SavingThrow>()
                                                                                         {
                                                                                             new SavingThrow() {Name = "Wis Saving Throw", Score = 0},
                                                                                             new SavingThrow() {Name = "Animal Handlig", Score = 0},
                                                                                              new SavingThrow() {Name = "Insight", Score = 0},
                                                                                               new SavingThrow() {Name = "Medicine", Score = 0},
                                                                                               new SavingThrow() {Name = "Perception", Score = 0},
                                                                                               new SavingThrow() {Name = "Survival", Score = 0},
                                                                                         } },
            new AbilityScore() {Name = "Charisma", ShortName = "CHA",SavingThrows = new BindingList<SavingThrow>()
                                                                                         {
                                                                                             new SavingThrow() {Name = "CHA Saving Throw", Score = 0},
                                                                                             new SavingThrow() {Name = "Deception", Score = 0},
                                                                                              new SavingThrow() {Name = "Intimidation", Score = 0},
                                                                                               new SavingThrow() {Name = "Performance", Score = 0},
                                                                                               new SavingThrow() {Name = "Persuasion", Score = 0},
                                                                                         } },

        };
    }
}
