/*using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestRequestProject;
using RestSharp;
using System.IO;

namespace RestRequestTest
{
    [TestClass]
    public class SendRequestTest
    {
        [TestMethod]
        public void ResponseValidTest()
        {
            ///compare response given from request and
            ///response given from textfile
            APIClient myClient = new APIClient();
            IRestRequest myRequest = new RestRequest();
            IRequestResponseProcessing processor = new ManageRequestResponse();
            myRequest = processor.BuildRequest("luke", myRequest);
            IRestResponse response = processor.MakeRequest(myClient, myRequest);

            //read response from file
            string path = @"C:\Users\USER\Desktop\Git repos\RestRequestProject\RestRequestProject\RestRequestTest\testdataLuke.txt";
            StreamReader sr = new StreamReader(path);
            string testContent = sr.ReadToEnd();

            Assert.AreEqual(response.Content.ToString(), testContent);
        }

        [TestMethod]
        public void ResponseInvalidTest()
        {
            ///compare response given from request and
            ///response given from textfile
            APIClient myClient = new APIClient();
            IRestRequest myRequest = new RestRequest();
            IRequestResponseProcessing processor = new ManageRequestResponse();
            //enter the name that doesn`t exist
            myRequest = processor.BuildRequest("mia", myRequest);
            IRestResponse response = processor.MakeRequest(myClient, myRequest);

            //read response from file
            string path = @"C:\Users\USER\Desktop\Git repos\RestRequestProject\RestRequestProject\RestRequestTest\testdataNull.txt";
            StreamReader sr = new StreamReader(path);
            string testContent = sr.ReadToEnd();

            Assert.AreEqual(response.Content.ToString(), testContent);
        }

        [TestMethod]
        public void SameRequestsComparisonTest()
        {
            //compare two responses from same requests
            APIClient myClient1 = new APIClient();
            IRestRequest myRequest1 = new RestRequest();
            IRequestResponseProcessing processor1 = new ManageRequestResponse();
            myRequest1 = processor1.BuildRequest("c-3po", myRequest1);
            IRestResponse response1 = processor1.MakeRequest(myClient1, myRequest1);

            APIClient myClient2 = new APIClient();
            IRestRequest myRequest2 = new RestRequest();
            IRequestResponseProcessing processor2 = new ManageRequestResponse();
            myRequest2 = processor2.BuildRequest("c-3po", myRequest2);
            IRestResponse response2 = processor2.MakeRequest(myClient2, myRequest2);

            Assert.AreEqual(response1.Content.ToString(), response2.Content.ToString());
        }

        [TestMethod]
        public void ResponseToHTMLTest()
        {
            APIClient myClient = new APIClient();
            IRestRequest myRequest = new RestRequest();
            IRequestResponseProcessing processor = new ManageRequestResponse();
            myRequest = processor.BuildRequest("Obi-Wan Kenobi", myRequest);
            IRestResponse response = processor.MakeRequest(myClient, myRequest);

            string path1 = @"C:\Users\USER\Desktop\Git repos\RestRequestProject\RestRequestProject\RestRequestTest\testdataCurrentHTML.html";
            processor.ShowResponseToHTML(response, path1);
            StreamReader sr1 = new StreamReader(path1);
            string testContent1 = sr1.ReadToEnd();

            //prepared testdata reading
            string path2 = @"C:\Users\USER\Desktop\Git repos\RestRequestProject\RestRequestProject\RestRequestTest\testdataSavedHTML.html";
            StreamReader sr2 = new StreamReader(path2);
            string testContent2 = sr2.ReadToEnd();

            Assert.AreEqual(testContent1, testContent2);

        }
    }
}
*/