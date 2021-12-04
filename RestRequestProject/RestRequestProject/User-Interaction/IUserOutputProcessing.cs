using System.Collections.Generic;
using RestSharp;

namespace RestRequestProject
{
    interface IUserOutputProcessing
    {
        void OutputToConsole(string output);
        void ShowResponseToConsole(Planet response);
        void ShowResponseToHTML(Planet response);
        void ShowResponseToHTML(Planet response, string path);
    }
}
