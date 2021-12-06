using RestSharp;
using System;
using System.IO;
using System.Collections.Generic;

namespace RestRequestProject
{
    class Program
    {
        static void  Main(string[] args)
        {
            APIClient.CreateClient();

            string parameter = "name";
            IUserOutputProcessing askName = new GetOutput();
            askName.OutputToConsole("Enter " + parameter + ":");
            IUserInputProcessing input = new GetInput();
            string userInput = input.GetUserConsoleInput();

            IRequestResponseProcessing processor = new ManageRequestResponse();
            Planet response = processor.MakeRequest(userInput);

            IUserOutputProcessing output = new GetOutput();

            string fileName = "file.txt";
            output.ShowResponseToTXT(response,fileName);

            /*string s = "https://swapi.dev/api/planets";
            RestClient cl = new RestClient();
            IRestRequest req = new RestRequest(s);
            //req.AddParameter("search", "toyda");
            IRestResponse resp = cl.Get(req);
            Console.WriteLine(resp.Content.ToString());*/



        }
    }
}
