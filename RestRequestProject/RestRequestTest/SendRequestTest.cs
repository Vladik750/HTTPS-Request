using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestRequestProject;
using RestSharp;
using System.IO;

namespace RestRequestTest
{
    [TestClass]
    public class SendRequestTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Client myClient = new Client();
            IRestRequest myRequest = new RestRequest();
            IRequestResponseProcessing processor = new ManageRequestResponse();
            myRequest = processor.BuildRequest("luke", myRequest);
            IRestResponse response = processor.MakeRequest(myClient, myRequest);

            string path = @"C:\Users\USER\Desktop\Git repos\RestRequestProject\RestRequestProject\RestRequestTest\testdata1.txt";
            StreamReader sr = new StreamReader(path);
            string testContent = sr.ReadToEnd();

            Assert.AreEqual(response.Content.ToString(), testContent);
        }
    }
}
