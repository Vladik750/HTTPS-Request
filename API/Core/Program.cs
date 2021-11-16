using System;
using RestSharp;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Client myClient = new Client();
            string parameter = "name";
            SayToUser askId = new SayToUser("Enter " + parameter + ": ");
            IGetUserInput consoleInput = new GetConsoleInput();

            IRestRequest myRequest = new RestRequest();
            IBuildRequest build = new ManageRequest();
            myRequest = build.BuildRequest(consoleInput, myRequest);
            IMakeRequest makeRequest = new ManageRequest();
            IRestResponse resp = makeRequest.MakeRequest(myClient, myRequest);

            //IShowResponse consoleResponse = new ResponseToConsole();
            IShowResponse responseHtml = new ResponseToHTML();
            //consoleResponse.ShowResponse(resp);
            responseHtml.ShowResponse(resp);

        }
    }
}
