using System;
using System.Collections.Generic;
using System.IO;
using RestSharp;
using System.Diagnostics;

namespace RestRequestProject
{
    public class ManageRequestResponse : IRequestResponseProcessing
    {
        //private IRestRequest request;
        //adds a search parameter to request
        public IRestRequest BuildRequest(string input)
        {
            IRestRequest request = new RestRequest();
            request.AddHeader("Accept", "application/json");
            request.AddParameter("search", input);
            return request;
        }
        public IRestResponse<List<Planet>> MakeRequest(string persName)
        {
            IRestResponse<List<Planet>> response = APIClient.client.Get<List<Planet>>(BuildRequest(persName));
            return response;
            //return APIClient.client.Get(BuildRequest(persName));
        }

        public IRestResponse<List<Planet>> MakeRequest(IRestRequest request)
        {
            request.AddHeader("Accept", "application/json");
            IRestResponse<List<Planet>> response = APIClient.client.Get<List<Planet>>(request);
            return response;
            //return APIClient.client.Get(request);
        }

    }
}
