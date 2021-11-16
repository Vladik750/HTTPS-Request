using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace API
{
    class ManageRequest : IMakeRequest, IBuildRequest
    {
        //adds a search parameter to request
        IRestRequest IBuildRequest.BuildRequest(IGetUserInput input, IRestRequest request )
        {
            string attribute = input.GetUserInput();
            return request.AddParameter("search", attribute);            
        }

        IRestResponse IMakeRequest.MakeRequest(Client client, IRestRequest request)
        {
            return client.client.Get(request);
        }
    }
}
