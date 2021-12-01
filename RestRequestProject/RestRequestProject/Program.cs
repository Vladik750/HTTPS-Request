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


            ///show response to json
            ///serialize json to object(dto)
            ///insert object to db
            ///
            /*APIClient.CreateClient();

            IRestRequest request = new RestRequest();
            request.AddParameter("search", "tatooine");
            IRestResponse<List<Planet>> response = APIClient.client.Get<List<Planet>>(request);
            for (int i = 0; i < response.Data.Count; i++)
            {
                response.Data[i].Show();
            }*/

        }
    }
}
