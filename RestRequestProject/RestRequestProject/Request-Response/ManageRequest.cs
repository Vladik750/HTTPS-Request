using System;
using RestSharp;

namespace RestRequestProject
{
    class ManageRequest : IRequestResponseProcessing
    {
        //adds a search parameter to request
        IRestRequest IRequestResponseProcessing.BuildRequest(IUserInputProcessing input, IRestRequest request)
        {
            string attribute = input.GetUserInput();
            return request.AddParameter("search", attribute);
        }

        IRestResponse IRequestResponseProcessing.MakeRequest(Client client, IRestRequest request)
        {
            return client.client.Get(request);
        }

        void IRequestResponseProcessing.PushResponseToDB(IRestResponse response, string db)
        {
            
            throw new NotImplementedException();
        }
    }
}
