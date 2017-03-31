using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Er kun Equipments fra 0 til 37
namespace DungeonsDragonsApi.Core.Models.Equipment
{
    using DungeonsDragonsApi.Core.Models.Shared;

    using Newtonsoft.Json;

    public class DamageType
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Damage
    {

        [JsonProperty("dice_count")]
        public int DiceCount { get; set; }

        [JsonProperty("dice_value")]
        public int DiceValue { get; set; }

        [JsonProperty("damage_type")]
        public DamageType DamageType { get; set; }
    }

    public class Range
    {

        [JsonProperty("normal")]
        public int Normal { get; set; }

        [JsonProperty("long")]
        public object Long { get; set; }
    }

    public class Property
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class ThrowRange
    {

        [JsonProperty("normal")]
        public int Normal { get; set; }

        [JsonProperty("long")]
        public int Long { get; set; }
    }

    public class Weapon
    {

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("equipment_category")]
        public string EquipmentCategory { get; set; }

        [JsonProperty("weapon_category:")]
        public string WeaponCategory { get; set; }

        [JsonProperty("weapon_range")]
        public string WeaponRange { get; set; }

        [JsonProperty("category_range")]
        public string CategoryRange { get; set; }

        [JsonProperty("cost")]
        public Cost Cost { get; set; }

        [JsonProperty("damage")]
        public Damage Damage { get; set; }

        [JsonProperty("range")]
        public Range Range { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("properties")]
        public IList<Property> Properties { get; set; }

        [JsonProperty("special")]
        public IList<string> Special { get; set; }

        [JsonProperty("throw_range")]
        public ThrowRange ThrowRange { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
