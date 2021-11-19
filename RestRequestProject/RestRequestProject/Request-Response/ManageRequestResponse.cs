using System;
using System.IO;
using RestSharp;
using System.Diagnostics;

namespace RestRequestProject
{
    public class ManageRequestResponse : IRequestResponseProcessing
    {
        //adds a search parameter to request
        IRestRequest IRequestResponseProcessing.BuildRequest(string input, IRestRequest request)
        {
            return request.AddParameter("search", input);
        }

        IRestResponse IRequestResponseProcessing.MakeRequest(Client client, IRestRequest request)
        {
            return client.client.Get(request);
        }

        void IRequestResponseProcessing.PushResponseToDB(IRestResponse response, string db)
        {
            throw new NotImplementedException();
        }

        void IRequestResponseProcessing.ShowResponseToConsole(IRestResponse response)
        {
            //Console.WriteLine(response.Content.ToString());
            IUserOutputProcessing consoleResponse = new GetOutput();
            consoleResponse.OutputToConsole(response.Content.ToString());
        }

        void IRequestResponseProcessing.ShowResponseToHTML(IRestResponse response)
        {
            string path = @"C:\Users\USER\source\repos\RestRequestProject\index.html";
            FileStream fs = File.Create(path);
            fs.Close();
            // write response to a file
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("<html>");
            streamWriter.WriteLine("<head>");
            streamWriter.WriteLine("  <title>HTML-Document</title>");
            streamWriter.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            streamWriter.WriteLine("</head>");
            streamWriter.WriteLine("<body>");
            streamWriter.WriteLine(response.Content.ToString());
            streamWriter.WriteLine("</body>");
            streamWriter.WriteLine("</html>");
            streamWriter.Close();

            //Open the file in the default browser
            Process process = new Process();
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.UseShellExecute = true;
            processInfo.FileName = path.ToString();
            process.StartInfo = processInfo;

            process.Start();
        }

        void IRequestResponseProcessing.ShowResponseToHTML(IRestResponse response, string path)
        {
            FileStream fs = File.Create(path);
            fs.Close();
            // write response to a file
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("<html>");
            streamWriter.WriteLine("<head>");
            streamWriter.WriteLine("  <title>HTML-Document</title>");
            streamWriter.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            streamWriter.WriteLine("</head>");
            streamWriter.WriteLine("<body>");
            streamWriter.WriteLine(response.Content.ToString());
            streamWriter.WriteLine("</body>");
            streamWriter.WriteLine("</html>");
            streamWriter.Close();

            //Open the file in the default browser
            Process process = new Process();
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.UseShellExecute = true;
            processInfo.FileName = path.ToString();
            process.StartInfo = processInfo;

            process.Start();
        }
    }
}
