using System.Collections.Generic;
using RestSharp;

namespace RestRequestProject
{
    public interface IRequestResponseProcessing
    {
        Planet MakeRequest(string persName);
        Planet MakeRequest(IRestRequest request);
    }
}
