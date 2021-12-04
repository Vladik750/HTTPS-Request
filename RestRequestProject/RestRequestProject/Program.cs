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

            output.ShowResponseToConsole(response);

            /*DBClient.CreateDBClient();
            DBManager dbManager = new DBManager();
            dbManager.InsertIntoDB(response);*/

            /*RestClient client = new RestClient("https://swapi.dev/api/planets");
            IRestRequest request = new RestRequest();
            request.AddHeader("Accept", "application/json");
            request.AddParameter("search", "tatooine");
            IRestResponse response = client.Get(request);
            Console.WriteLine(response.Content.ToString());
            Console.WriteLine("---");
            string param = request.Parameters[1].ToString();
            Console.WriteLine(param);*/

            ///request comparicon by request parameters 
        }
    }
}
