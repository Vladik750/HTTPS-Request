using System;
using RestSharp;

namespace RestRequestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Client myClient = new Client();
            string parameter = "name";
            IUserOutputProcessing askId = new OutputToConsole();
            askId.Output("Enter " + parameter + ":");
            IUserInputProcessing consoleInput = new GetConsoleInput();

            IRestRequest myRequest = new RestRequest();
            IRequestResponseProcessing processor = new ManageRequest();
            myRequest = processor.BuildRequest(consoleInput, myRequest);
            IRestResponse resp = processor.MakeRequest(myClient, myRequest);

            IShowResponse consoleResponse = new ResponseToConsole();
            //IShowResponse responseHtml = new ResponseToHTML();
            consoleResponse.ShowResponse(resp);
            //responseHtml.ShowResponse(resp);
        }
    }
}
