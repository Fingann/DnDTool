using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsDragonsApi.Core.Models.Character_Data;
using RestSharp;

namespace DungeonsDragonsApi.Net
{
    public class AbilityScoreClient
    {
        private IRestClient restClient;

        public AbilityScoreClient()
        {
            this.restClient = new RestClient(new Uri("http://dnd5eapi.co/api"));

        }


        public AbilityScoreNames GetSpellNameAll()
        {
            IRestRequest restRequest = new RestRequest("ability-scores/", Method.GET);
            restRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var test = this.restClient.Execute<AbilityScoreNames>(restRequest).Data;
            return test;
        }

        public AbilityScore Get(string Url)
        {

            var apiPath = Url.Substring(22);
            IRestRequest restRequest = new RestRequest(apiPath.ToString(), Method.GET);
            restRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            return this.restClient.Execute<AbilityScore>(restRequest).Data;
        }
    }
}
