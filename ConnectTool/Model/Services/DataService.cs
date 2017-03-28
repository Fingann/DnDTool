// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataService.cs" company="BKK">
//   
// </copyright>
// <summary>
//   The data service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using DnDTool.Interface;

namespace DnDTool.Model.Services
{
    using DnDTool.Model.Character;

    /// <summary>
    /// The data service.
    /// </summary>
    public class DataService : IDataService
    {
        /// <summary>
        /// The get data.
        /// </summary>
        /// <param name="callback">
        /// The callback.
        /// </param>
        public void GetData(Action<DataItem, Exception> callback)
        {
           
            // Use this to connect to the actual data service
            var item = new DataItem("Welcome to MVVM Light");
            callback(item, null);
        }
        public void GetCharecter(Action<Character, Exception> callback)
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
                ExperiancePoints = 940,
                Level = 5,
                PlayerName = "Sondre",
                Race = "Half-Orc"
            };


            var item = new Character() { Info = info, AbilityScores = abilityScores };
            callback(item, null);
        }




    }
}