using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace API
{
    class ResponseToHTML : IShowResponse
    {
        private string path = @"C:\Users\USER\source\repos\API\index.html";
        void IShowResponse.ShowResponse(IRestResponse response)
        {
            // Create a file 
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
