using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsDragonsApi.Net
{
    using DungeonsDragonsApi.Core.Models;
    using DungeonsDragonsApi.Core.Models.Spells;

    using RestSharp;

    public class SpellsClient
    {
      
        private IRestClient restClient;

        public SpellsClient()
        {
            this.restClient = new RestClient(new Uri("http://dnd5eapi.co/api"));
      
            
        }


        public SpellNames GetSpellNameAll()
        {
            IRestRequest restRequest = new RestRequest("spells/", Method.GET);
            restRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var test =  this.restClient.Execute<SpellNames>(restRequest).Data;
            return test;
        }

        public Spell GetSpell(string Url)
        {

            var apiPath = Url.Substring(22);
            IRestRequest restRequest = new RestRequest(apiPath.ToString(), Method.GET);
            restRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            restRequest.AddParameter("id", "index", ParameterType.UrlSegment);
            return this.restClient.Execute<Spell>(restRequest).Data;
        }
    }
}
