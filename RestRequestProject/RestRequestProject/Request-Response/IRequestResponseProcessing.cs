using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestRequestProject
{
    interface IRequestResponseProcessing
    {
        IRestResponse MakeRequest(Client client, IRestRequest request);
        IRestRequest BuildRequest(string input, IRestRequest request);
        void PushResponseToDB(IRestResponse response, string db);
    }
}
