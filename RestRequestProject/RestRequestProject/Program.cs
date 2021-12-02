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
            IRestResponse<List<Planet>> response = processor.MakeRequest(userInput);

            IUserOutputProcessing output = new GetOutput();

            output.ShowResponseToConsole(response);

            DBClient dbCLient = new DBClient();
            dbCLient.PushResponseToDB(response);


        }
    }
}
