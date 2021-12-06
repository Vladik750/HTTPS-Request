using System.Collections.Generic;
using RestSharp;

namespace RestRequestProject
{
    public interface IUserOutputProcessing
    {
        void OutputToConsole(string output);
        void ShowResponseToConsole(Planet response);
        void ShowResponseToHTML(Planet response);
        void ShowResponseToHTML(Planet response, string path);
        void ShowResponseToTXT(Planet response, string fileName);
    }
}
