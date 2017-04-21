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
    using DnDTool.Core.Model.Character;

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

            var abilityScores = new AbilityScores();
            //{
            //    Abilityscore =
                                        
            //                                new List<AbilityScore>()
            //                                    {
            //                                        new AbilityScore() {  ShortName = "STR", Name = "Strength", Score = 10, Url = "ht" },
            //                                        new AbilityScore() {ShortName = "DEX", Name = "Dexterity", Score = 13, Url = "ht" },
            //                                        new AbilityScore() {  ShortName = "CON", Name = "Constitution", Score = 15, Url = "ht" },
            //                                        new AbilityScore() { ShortName = "Int", Name = "Intelligence", Score = 12, Url = "ht" },
            //                                        new AbilityScore() { ShortName = "WIS", Name = "Wisdom", Score = 3, Url = "ht" },
            //                                        new AbilityScore() { ShortName = "CHA", Name = "Charisma", Score = 9, Url = "ht" }
            //                                    },
            //    Inspiration = 1,
            //    PassiveWisdom = 0,
            //    ProficiencyBonus = 2
            //};


            var info = new Info()
            {
                Allignment = "Natural Evil",
                Background = "Pirate",
                CharecterName = "Malov",
                Class = "Barbarian",
                ExperiencePoints = 940,
                Level = 5,
                PlayerName = "Sondre",
                Race = "Half-Orc"
            };


            var traits = new Traits()
            {
                Bonds = "Avenge my father",
                Flaws = "Cant handle my booze",
                Ideals = "Honor, glory and women",
                PersonalTraits = "Like Choclate, i really like Choclate"
            };
            var item = new Character() { Info = info, AbilityScores = abilityScores, Traits = traits };
            callback(item, null);
        }




    }
}