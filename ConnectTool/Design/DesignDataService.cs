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
    using System.Collections.ObjectModel;

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
            var abilityScores = new AbilityScores();
            abilityScores.Abilityscore.First().SavingThrows.First().BaseScore = 3;
            foreach (var abilityScore in abilityScores.Abilityscore)
            {
                foreach (var VARIABLE in abilityScore.SavingThrows)
                {
                    VARIABLE.BaseScore = new Random().Next(8,15);
                }
            }

            var background = new Background()
            {
                Age = "15",
                Backstroy =
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                    , Hair = "Brown",
                Eyes = "blue", Weight = "50 lb", Skin = "Green", Height = "1,5 Meter", Tresures = new ObservableCollection<string>() { "Hairy old tooth", "Foot ofa goblin", "Head of a dragon"}
            };
          
            var info = new Info()
                           {
                               Allignment = "Natural Evil", Background = "Pirate", CharecterName = "Malov", Class = "Barbarian", ExperiencePoints = 940, Level = 5, PlayerName = "Sondre", Race = "Half-Orc"
                           };
            

            var traits = new Traits()
            {
                Bonds = "Avenge my father",
                Flaws = "Cant handle my booze",
                Ideals = "Honor, glory and women",
                PersonalTraits = "Like Choclate, i really like Choclate"
            };
            var item = new Character() {Info  = info, AbilityScores = abilityScores, Traits = traits, Background = background};
            callback(item, null);
        }
    }
}