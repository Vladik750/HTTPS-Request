using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;


namespace RestRequestProject
{
    class GetOutput:IUserOutputProcessing
    {
        public void OutputToConsole(string output)
        {
            Console.WriteLine(output);
        }

        public void ShowResponseToConsole(Planet response)
        {
            response.Show();
        }

        public void ShowResponseToHTML(Planet response)
        {
            string path = @"C:\Users\USER\Desktop\Cyber\RestRequestProject\RestRequestProject\RestRequestTest";
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
            for(int i=0;i<response.Results.Count;i++)
            {
                streamWriter.WriteLine(response.Results[i].ToString());
            }
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

        public void ShowResponseToHTML(Planet response, string path)
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
            for (int i = 0; i < response.Results.Count; i++)
            {
                streamWriter.WriteLine(response.Results[i].ToString());
            }
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
