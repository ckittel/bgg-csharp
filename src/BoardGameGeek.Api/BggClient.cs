using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoardGameGeek.Api.ClientModels;
using BoardGameGeek.Api.ServerModels;
using RestSharp;
using RestSharp.Deserializers;

namespace BoardGameGeek.Api
{
    public class BggClient
    {
        /// <summary>
        /// Initializes a BoardGameGeek API client
        /// </summary>
        public BggClient()
        {
            BaseUri = new Uri("http://www.boardgamegeek.com/xmlapi2/");
            _restClient = new RestClient(BaseUri.AbsoluteUri);
        }

        private readonly RestClient _restClient;

        /// <summary>
        /// Gets or sets the base uri for all requests.  This defaults to http://www.boardgamegeek.com/xmlapi2/
        /// </summary>
        public Uri BaseUri { get; set; }

        public Account GetAccount(string username)
        {
            var request = new RestRequest();
            request.Resource = "user";
            request.Method = Method.GET;

            request.AddParameter("name", username,  ParameterType.GetOrPost);

            var user = Execute<User>(request);
            return new Account();
        }

        private T Execute<T>(IRestRequest request) where T : new()
        {
            var response = _restClient.Execute<T>(request);
            return response.Data;
        }
    }
}
