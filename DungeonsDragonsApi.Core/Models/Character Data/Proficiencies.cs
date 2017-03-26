using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DungeonsDragonsApi.Core.Models.Character_Data
{
   
    public class Proficiencies
    {
        public string _id { get; set; }
        public int index { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        //[JsonProperty("eighty_min_score")]
        public List<Result> classes { get; set; }
        public List<Result> races { get; set; }
        public string url { get; set; }
    }
}
