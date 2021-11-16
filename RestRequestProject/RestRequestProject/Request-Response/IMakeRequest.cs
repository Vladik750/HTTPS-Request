using System;
using RestSharp;

namespace RestRequestProject
{
    interface IMakeRequest
    {
        IRestResponse MakeRequest(Client client, IRestRequest request);
    }
}
