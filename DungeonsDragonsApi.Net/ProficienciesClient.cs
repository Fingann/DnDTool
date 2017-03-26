using System;
using DungeonsDragonsApi.Core.Models.Character_Data;
using RestSharp;

namespace DungeonsDragonsApi.Net
{
    internal class ProficienciesClient
    {
        private IRestClient restClient;

        public ProficienciesClient()
        {
            restClient = new RestClient(new Uri("http://dnd5eapi.co/api"));
        }

        public RootObject GetSpellNameAll()
        {
            IRestRequest restRequest = new RestRequest("ability-scores/", Method.GET);
            restRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var test = this.restClient.Execute<RootObject>(restRequest).Data;
            return test;
        }

        public Proficiency Get(string Url)
        {

            var apiPath = Url.Substring(22);
            IRestRequest restRequest = new RestRequest(apiPath.ToString(), Method.GET);
            restRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            return this.restClient.Execute<>(restRequest).Data;
        }
    }
}