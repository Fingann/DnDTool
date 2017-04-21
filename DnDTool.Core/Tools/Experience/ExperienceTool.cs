using System.Runtime.CompilerServices;


namespace DnDTool.Core.Tools.Experience
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    
    internal static class ExperienceTool
    {
        private static List<CharacterAdvancement> ExperienceAdvancments = new List<CharacterAdvancement>
        {
            new CharacterAdvancement(0, 1, 2),
            new CharacterAdvancement(300, 2, 2),
            new CharacterAdvancement(900, 3, 2),
            new CharacterAdvancement(2700, 4, 2),
            new CharacterAdvancement(6500, 5, 3),
            new CharacterAdvancement(14000, 6, 3),
            new CharacterAdvancement(23000, 7, 3),
            new CharacterAdvancement(34000, 8, 3),
            new CharacterAdvancement(48000, 9, 3),
            new CharacterAdvancement(64000, 10, 3),
            new CharacterAdvancement(85000, 11, 4),
            new CharacterAdvancement(100000, 12, 4),
            new CharacterAdvancement(120000, 13, 5),
            new CharacterAdvancement(140000, 14, 5),
            new CharacterAdvancement(165000, 15, 5),
            new CharacterAdvancement(195000, 16, 5),
            new CharacterAdvancement(225000, 17, 6),
            new CharacterAdvancement(265000, 18, 6),
            new CharacterAdvancement(305000, 19, 6),
            new CharacterAdvancement(355000, 20, 6)
        };


        public static int GetLevel(int experience)
        {
            var last = ExperienceAdvancments.Last();
            if (experience > last.Experience)
            {
                return last.Level;
            }
            //Finds the first level greater then experience and returns the level before

            return ExperienceAdvancments.First(x => Math.Max(x.Experience, experience) != experience).Level - 1;
        }

        public static int GetProficiencyBonus(int experiance)
        {
            if (experiance < 0)
            {
                return ExperienceAdvancments.First().ProficiencyBonus;
            }

            var index = ExperienceAdvancments.FindIndex(x => Math.Max(x.Experience, experiance) != experiance) - 1;
            return ExperienceAdvancments[index].ProficiencyBonus;
        }

        }
    }
