using System.Collections.Generic;
using RestSharp;

namespace RestRequestProject
{
    interface IUserOutputProcessing
    {
        void OutputToConsole(string output);
        void ShowResponseToConsole(IRestResponse<List<Planet>> response);
        void ShowResponseToHTML(IRestResponse<List<Planet>> response);
        void ShowResponseToHTML(IRestResponse<List<Planet>> response, string path);
    }
}
