using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;


namespace RestRequestProject
{
    public class GetOutput:IUserOutputProcessing
    {
        public void OutputToConsole(string output)
        {
            Console.WriteLine(output);
        }

        public void ShowResponseToConsole(Planet response)
        {
            response.Show();
        }

        public void ShowResponseToTXT(Planet response, string fileName)
        {
            FileStream fs = File.Create(fileName);
            fs.Close();

            StreamWriter sw = new StreamWriter(fileName);
            for(int i=0;i<response.Results.Count;i++)
            {
                sw.WriteLine(response.Results[i].Name.ToString());
                sw.WriteLine(response.Results[i].Diameter.ToString());
                sw.WriteLine(response.Results[i].Climate.ToString());
                sw.WriteLine(response.Results[i].Gravity.ToString());
                sw.WriteLine(response.Results[i].Population.ToString());
            }
            sw.Close();
        }

        public void ShowResponseToHTML(Planet response)
        {
            string path = @"C:\Users\USER\Desktop\Cyber\RestRequestProject\RestRequestProject\RestRequestTest";
            FileStream fs = File.Create(path);
            fs.Close();
            // write response to a file
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("<html>");
            sw.WriteLine("<head>");
            sw.WriteLine("  <title>HTML-Document</title>");
            sw.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            sw.WriteLine("</head>");
            sw.WriteLine("<body>");
            for(int i=0;i<response.Results.Count;i++)
            {
                sw.WriteLine(response.Results[i].Name.ToString());
                sw.WriteLine(response.Results[i].Diameter.ToString());
                sw.WriteLine(response.Results[i].Climate.ToString());
                sw.WriteLine(response.Results[i].Gravity.ToString());
                sw.WriteLine(response.Results[i].Population.ToString());
            }
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            sw.Close();

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
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("<html>");
            sw.WriteLine("<head>");
            sw.WriteLine("  <title>HTML-Document</title>");
            sw.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            sw.WriteLine("</head>");
            sw.WriteLine("<body>");
            for (int i = 0; i < response.Results.Count; i++)
            {
                sw.WriteLine(response.Results[i].Name.ToString());
                sw.WriteLine(response.Results[i].Diameter.ToString());
                sw.WriteLine(response.Results[i].Climate.ToString());
                sw.WriteLine(response.Results[i].Gravity.ToString());
                sw.WriteLine(response.Results[i].Population.ToString());
            }
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            sw.Close();

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
