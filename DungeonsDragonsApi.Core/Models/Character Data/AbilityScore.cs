using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DungeonsDragonsApi.Core.Models.Character_Data
{
  
    public class Skill
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class AbilityScore
    {
        public string _id { get; set; }
        public int index { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public List<string> desc { get; set; }
        [JsonProperty("eighty_min_score")]
        public List<Skill> skills { get; set; }
        public string url { get; set; }
    }

    public class AbilityScoreNames
    {
        public int count { get; set; }
        public List<Result> results { get; set; }
    }
}
