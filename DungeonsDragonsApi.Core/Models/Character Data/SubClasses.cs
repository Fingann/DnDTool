using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsDragonsApi.Core.Models.Character_Data
{
    using Newtonsoft.Json;

    public class SubClasses
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public IList<Result> Results { get; set; }
    }

}
