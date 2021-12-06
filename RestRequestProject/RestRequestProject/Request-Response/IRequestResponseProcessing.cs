using System.Collections.Generic;
using RestSharp;

namespace RestRequestProject
{
    public interface IRequestResponseProcessing
    {
        Planet MakeRequest(string input);
        Planet MakeRequest(IRestRequest request);
    }
}
