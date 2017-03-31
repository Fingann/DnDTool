using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsDragonsApi.Core.Models.Equipment
{
    using DungeonsDragonsApi.Core.Models.Shared;

    using Newtonsoft.Json;

    public class ArmorClass
    {

        [JsonProperty("base")]
        public int Base { get; set; }

        [JsonProperty("dex_bonus")]
        public bool DexBonus { get; set; }

        [JsonProperty("max_bonus")]
        public int MaxBonus { get; set; }
    }

  

    public class Armor
    {

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype:")]
        public string Subtype { get; set; }

        [JsonProperty("armor_class")]
        public ArmorClass ArmorClass { get; set; }

        [JsonProperty("strength")]
        public int Strength { get; set; }

        [JsonProperty("stealth")]
        public string Stealth { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("cost")]
        public Cost Cost { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

}
