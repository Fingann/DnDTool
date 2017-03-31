using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsDragonsApi.Core.Models.Classes
{
    using Newtonsoft.Json;

    public class Races
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public IList<Result> Results { get; set; }
    }
}
