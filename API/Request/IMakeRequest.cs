using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace API
{
    interface IMakeRequest
    {
        IRestResponse MakeRequest(Client client, IRestRequest request);
    }
}
