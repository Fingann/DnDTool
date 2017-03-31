using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsDragonsApi.Core.Models.Classes
{
    using Newtonsoft.Json;

    public class From
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ProficiencyChoice
    {

        [JsonProperty("from")]
        public IList<From> From { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("choose")]
        public int Choose { get; set; }
    }

    public class Proficiency
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SavingThrow
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class StartingEquipment
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public class ClassLevels
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public class Subclass
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Spellcasting
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }
    }

    public class PlayerClass
    {

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hit_die")]
        public int HitDie { get; set; }

        [JsonProperty("proficiency_choices")]
        public IList<ProficiencyChoice> ProficiencyChoices { get; set; }

        [JsonProperty("proficiencies")]
        public IList<Proficiency> Proficiencies { get; set; }

        [JsonProperty("saving_throws")]
        public IList<SavingThrow> SavingThrows { get; set; }

        [JsonProperty("starting_equipment")]
        public StartingEquipment StartingEquipment { get; set; }

        [JsonProperty("class_levels")]
        public ClassLevels ClassLevels { get; set; }

        [JsonProperty("subclasses")]
        public IList<Subclass> Subclasses { get; set; }

        [JsonProperty("spellcasting")]
        public Spellcasting Spellcasting { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

}
