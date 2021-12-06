using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestRequestProject;
using System.IO;

namespace RestRequestTests
{
    [TestClass]
    public class RestTest
    {
        [TestMethod]
        public void ResponseValidTest()
        {
            ///compare response given from request and
            ///prepared response given from textfile
            APIClient.CreateClient();
            IRequestResponseProcessing processor = new ManageRequestResponse();
            Planet response = processor.MakeRequest("tatooine");
            IUserOutputProcessing output = new GetOutput();
            output.ShowResponseToTXT(response,"testTatooine.txt");

            StreamReader sr = new StreamReader("testTatooine.txt");
            string current = sr.ReadToEnd();
            sr.Close();
            sr = new StreamReader("Tatooine.txt");
            string test = sr.ReadToEnd();

            Assert.AreEqual(current, test);   
        }

        [TestMethod]
        public void ResponseInvalidTest()
        {
            APIClient.CreateClient();
            IRequestResponseProcessing processor = new ManageRequestResponse();
            Planet response = processor.MakeRequest("alderaan");
            IUserOutputProcessing output = new GetOutput();
            output.ShowResponseToTXT(response, "testTatooine.txt");

            StreamReader sr = new StreamReader("testTatooine.txt");
            string current = sr.ReadToEnd();
            sr.Close();
            sr = new StreamReader("Tatooine.txt");
            string test = sr.ReadToEnd();

            Assert.AreNotEqual(current, test);
        }

        [TestMethod]
        public void DbResponseTest()
        {
            ///makes a request which response is already in the db
            ///so request attempts should be equal to zero.
            APIClient.CreateClient();
            ManageRequestResponse processor = new ManageRequestResponse();
            Planet response = processor.MakeRequest("tatooine");

            Assert.AreEqual(processor.GetRequestAttempts(),0);
        }

        [TestMethod]
        public void NotDbResponseTest()
        {
            ///makes a request which response is not in the db
            ///so request attempts should be not equal to zero.

            DBClient.CreateDBClient();
            DBClient.OpenConnection();
            var command = DBClient.CreateCommand();
            command.CommandText = "delete from response where Name='Tatooine';";
            command.ExecuteReader();
            DBClient.CloseConnection();

            APIClient.CreateClient();
            ManageRequestResponse processor = new ManageRequestResponse();
            Planet response = processor.MakeRequest("tatooine");

            Assert.AreNotEqual(processor.GetRequestAttempts(), 0);
        }
    }
}
