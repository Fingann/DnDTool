using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDTool.Core;
using DnDTool.Core.Strategy.Update;
using DnDTool.Model.Character;
using NUnit.Framework;

namespace DnDToolTests
{
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
                                                    new AbilityScore() { Bonus = 3, Name = "Strength", Score = 10, Url = "ht" },
                                                    new AbilityScore() { Bonus = 2, Name = "Dexterity", Score = 13, Url = "ht" },
                                                    new AbilityScore() { Bonus = 3, Name = "Constitution", Score = 15, Url = "ht" },
                                                    new AbilityScore() { Bonus = 0, Name = "Intelligence", Score = 12, Url = "ht" },
                                                    new AbilityScore() { Bonus = 1, Name = "Wisdom", Score = 3, Url = "ht" },
                                                    new AbilityScore() { Bonus = -2, Name = "Charisma", Score = 9, Url = "ht" }
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
                    ExperiancePoints = 24000,
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
            CharacterManager charManager = new CharacterManager(Character);
            charManager.SetSortStrategy(new LevelUpdate());
        }
    }
}

