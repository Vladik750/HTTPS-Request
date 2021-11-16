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
        IRestRequest BuildRequest(IUserInputProcessing input, IRestRequest request);
        void PushResponseToDB(IRestResponse response, string db);
    }
}
