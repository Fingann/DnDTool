﻿using System;
using DungeonsDragonsApi.Core.Models;
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

        public Proficiencies GetProficiencyAll()
        {
            IRestRequest restRequest = new RestRequest("ability-scores/", Method.GET);
            restRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var test = this.restClient.Execute<Proficiencies>(restRequest).Data;
            return test;
        }

        public Proficiencies Get(string Url)
        {

            var apiPath = Url.Substring(22);
            IRestRequest restRequest = new RestRequest(apiPath.ToString(), Method.GET);
            restRequest.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            return this.restClient.Execute<Proficiencies>(restRequest).Data;
        }
    }
}