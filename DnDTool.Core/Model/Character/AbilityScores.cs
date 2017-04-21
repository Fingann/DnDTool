namespace DnDTool.Core.Model.Character
{
    using System.Collections.Generic;
    using System.ComponentModel;

    using DnDTool.Core.Strategy.Update;

    using PropertyChanged;

    [ImplementPropertyChanged]
    public class AbilityScores
    {
        private int proficiencyBonus = 2;

        public int ProficiencyBonus
        {
            get
            {
                return this.proficiencyBonus;
            }
            set
            {
                this.proficiencyBonus = value;
                CharacterManager.Instance.Update(new UpdateSavingThrowProficiency());
            }
        }

        public int Inspiration { get; set; } = 0;

        public int PassiveWisdom { get; set; } = 0;

        public List<AbilityScore> Abilityscore { get; set; }= new List<AbilityScore>()
        {
            new AbilityScore() {Name = "Strength", ShortName = "STR", SavingThrows = new BindingList<SavingThrow>()
                                                                                         {
                                                                                             new SavingThrow() {Name = "Saving Throw", BaseScore = 0},
                                                                                             new SavingThrow() {Name = "Athletics", BaseScore = 0}
                                                                                         } },
            new AbilityScore() {Name = "Constitution", ShortName = "CON", SavingThrows = new BindingList<SavingThrow>()
                                                                                         {
                                                                                             new SavingThrow() {Name = "Saving Throw", BaseScore = 0}

                                                                                         } },
            new AbilityScore() {Name = "Dexterity", ShortName = "DEX",SavingThrows = new BindingList<SavingThrow>()
                                                                                         {
                                                                                             new SavingThrow() {Name = "Saving Throw", BaseScore = 0},
                                                                                             new SavingThrow() {Name = "Acrobatics", BaseScore = 0},
                                                                                              new SavingThrow() {Name = "Slight Of Hand", BaseScore = 0},
                                                                                               new SavingThrow() {Name = "Stealth", BaseScore = 0},
                                                                                         } },
            new AbilityScore() {Name = "Intellegence", ShortName = "INT",SavingThrows = new BindingList<SavingThrow>()
                                                                                         {
                                                                                             new SavingThrow() {Name = "Saving Throw", BaseScore = 0},
                                                                                             new SavingThrow() {Name = "Arcana", BaseScore = 0},
                                                                                              new SavingThrow() {Name = "History", BaseScore = 0},
                                                                                               new SavingThrow() {Name = "Investigation", BaseScore = 0},
                                                                                                new SavingThrow() {Name = "Nature", BaseScore = 0},
                                                                                                 new SavingThrow() {Name = "Religion", BaseScore = 0},
                                                                                         } },
            new AbilityScore() {Name = "Wisdom", ShortName = "WIS",SavingThrows = new BindingList<SavingThrow>()
                                                                                         {
                                                                                             new SavingThrow() {Name = "Saving Throw", BaseScore = 0},
                                                                                             new SavingThrow() {Name = "Animal Handlig", BaseScore = 0},
                                                                                              new SavingThrow() {Name = "Insight", BaseScore = 0},
                                                                                               new SavingThrow() {Name = "Medicine", BaseScore = 0},
                                                                                               new SavingThrow() {Name = "Perception", BaseScore = 0},
                                                                                               new SavingThrow() {Name = "Survival", BaseScore = 0},
                                                                                         } },
            new AbilityScore() {Name = "Charisma", ShortName = "CHA",SavingThrows = new BindingList<SavingThrow>()
                                                                                         {
                                                                                             new SavingThrow() {Name = "Saving Throw", BaseScore = 0},
                                                                                             new SavingThrow() {Name = "Deception", BaseScore = 0},
                                                                                              new SavingThrow() {Name = "Intimidation", BaseScore = 0},
                                                                                               new SavingThrow() {Name = "Performance", BaseScore = 0},
                                                                                               new SavingThrow() {Name = "Persuasion", BaseScore = 0},
                                                                                         } },

        };
    }
}
