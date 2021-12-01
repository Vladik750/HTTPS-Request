using System.Collections.Generic;
using RestSharp;

namespace RestRequestProject
{
    public interface IRequestResponseProcessing
    {
        IRestResponse<List<Planet>> MakeRequest(string persName);
        IRestResponse<List<Planet>> MakeRequest(IRestRequest request);
    }
}
