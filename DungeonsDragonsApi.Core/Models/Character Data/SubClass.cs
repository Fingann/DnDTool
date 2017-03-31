using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsDragonsApi.Core.Models.Character_Data
{
    using Newtonsoft.Json;

    public class Class
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class SubClass
    {

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("subclass_flavor")]
        public string SubclassFlavor { get; set; }

        [JsonProperty("desc")]
        public IList<string> Desc { get; set; }

        [JsonProperty("features")]
        public IList<object> Features { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
