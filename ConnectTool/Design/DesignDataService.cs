// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DesignDataService.cs" company="BKK">
//   
// </copyright>
// <summary>
//   Defines the DesignDataService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using DnDTool.Interface;
using DnDTool.Model;
using DnDTool.Model.Services;

namespace DnDTool.Design
{
    using DnDTool.Core.Model.Character;

    using DungeonsDragonsApi.Core.Models;

    /// <summary>
    /// The design data service.
    /// </summary>
    public class DesignDataService : IDataService
    {
        /// <summary>
        /// The get data.
        /// </summary>
        /// <param name="callback">
        /// The callback.
        /// </param>
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to create design time data
            var item = new DataItem("Welcome to MVVM Light [design]");
            callback(item, null);
        }

        public void GetCharecter(Action<Character, Exception> callback)
        {
            var abilityScores = new AbilityScores()
                                    {
                                        Abilityscore =
                                            new List<AbilityScore>()
                                                {
                                                    new AbilityScore() { Bonus = 3, ShortName = "STR", Name = "Strength", Score = 10, Url = "ht" },
                                                    new AbilityScore() { Bonus = 2, ShortName = "DEX", Name = "Dexterity", Score = 13, Url = "ht" },
                                                    new AbilityScore() { Bonus = 3, ShortName = "CON", Name = "Constitution", Score = 15, Url = "ht" },
                                                    new AbilityScore() { Bonus = 0,ShortName = "INT", Name = "Intelligence", Score = 12, Url = "ht" },
                                                    new AbilityScore() { Bonus = 1,ShortName = "WIS", Name = "Wisdom", Score = 3, Url = "ht" },
                                                    new AbilityScore() { Bonus = -2,ShortName = "CHA", Name = "Charisma", Score = 9, Url = "ht" }
                                                },Inspiration = 1, PassiveWisdom = 0, ProficiencyBonus = 2
                                    };

            var info = new Info()
                           {
                               Allignment = "Natural Evil", Background = "Pirate", CharecterName = "Malov", Class = "Barbarian", ExperiancePoints = 940, Level = 5, PlayerName = "Sondre", Race = "Half-Orc"
                           };

            var traits = new Traits()
            {
                Bonds = "Avenge my father",
                Flaws = "Cant handle my booze",
                Ideals = "Honor, glory and women",
                PersonalTraits = "Like Choclate, i really like Choclate"
            };
            var item = new Character() {Info  = info, AbilityScores = abilityScores, Traits = traits};
            callback(item, null);
        }
    }
}