using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsDragonsApi.Core.Models.Equipment
{
    using Newtonsoft.Json;

    public class Equipments
    {

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public IList<Result> Results { get; set; }
    }

}
