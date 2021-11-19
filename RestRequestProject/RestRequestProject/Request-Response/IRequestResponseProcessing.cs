using System;
using RestSharp;

namespace RestRequestProject
{
    public interface IRequestResponseProcessing
    {
        IRestResponse MakeRequest(Client client, IRestRequest request);
        IRestRequest BuildRequest(string input, IRestRequest request);
        void PushResponseToDB(IRestResponse response, string db);
        void ShowResponseToConsole(IRestResponse response);
        void ShowResponseToHTML(IRestResponse response);
        void ShowResponseToHTML(IRestResponse response, string path);
    }
}
