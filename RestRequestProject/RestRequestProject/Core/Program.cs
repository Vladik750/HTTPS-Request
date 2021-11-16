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
            IUserOutputProcessing askName = new GetOutput();
            askName.OutputToConsole("Enter " + parameter + ":");
            IUserInputProcessing input = new GetInput();
            string userInput = input.GetUserConsoleInput();

            IRestRequest myRequest = new RestRequest();
            IRequestResponseProcessing processor = new ManageRequest();
            myRequest = processor.BuildRequest(userInput, myRequest);
            IRestResponse resp = processor.MakeRequest(myClient, myRequest);

            IShowResponse consoleResponse = new ResponseToConsole();
            //IShowResponse responseHtml = new ResponseToHTML();
            consoleResponse.ShowResponse(resp);
            //responseHtml.ShowResponse(resp);
        }
    }
}
