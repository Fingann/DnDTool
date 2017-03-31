using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsDragonsApi.Core.Models.GameMechanics
{
    using Newtonsoft.Json;

    public class DamageType
    {

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public IList<string> Desc { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
