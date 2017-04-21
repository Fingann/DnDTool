using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDTool.Core;
using DnDTool.Core.Strategy.Update;

using NUnit.Framework;

namespace DnDToolTests
{
    using DnDTool.Core.Model.Character;

    [TestFixture]
    class CharacterManagerTests
    {

        public Character Character
        {
            get
            {
                var abilityScores = new AbilityScores()
                {
                    Abilityscore =
                                           new List<AbilityScore>()
                                               {
                                                    new AbilityScore() { Name = "Strength", Score = 10, Url = "ht" },
                                                    new AbilityScore() {  Name = "Dexterity", Score = 13, Url = "ht" },
                                                    new AbilityScore() { Name = "Constitution", Score = 15, Url = "ht" },
                                                    new AbilityScore() {  Name = "Intelligence", Score = 12, Url = "ht" },
                                                    new AbilityScore() {  Name = "Wisdom", Score = 3, Url = "ht" },
                                                    new AbilityScore() { Name = "Charisma", Score = 9, Url = "ht" }
                                               },
                    Inspiration = 1,
                    PassiveWisdom = 0,
                    ProficiencyBonus = 2
                };

                var info = new Info()
                {
                    Allignment = "Natural Evil",
                    Background = "Pirate",
                    CharecterName = "Malov",
                    Class = "Barbarian",
                    ExperiencePoints = 24000,
                    Level = 0,
                    PlayerName = "Sondre",
                    Race = "Half-Orc"
                };


                var item = new Character() { Info = info, AbilityScores = abilityScores };
                return item;
            }
          
        }


        [Test]
        public void CharacterManagerTest()
        {
            CharacterManager.Instance.Character = Character;
            CharacterManager.Instance.SetUpdateStrategy(new UpdateLevel());
            CharacterManager.Instance.Update();
        }
    }
}

