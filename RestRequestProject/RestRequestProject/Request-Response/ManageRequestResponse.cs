using System;
using System.Collections.Generic;
using System.IO;
using RestSharp;
using System.Diagnostics;

namespace RestRequestProject
{
    public class ManageRequestResponse : IRequestResponseProcessing
    {
        //adds a search parameter to request
        public IRestRequest BuildRequest(string input)
        {
            IRestRequest request = new RestRequest();
            request.AddHeader("Accept", "application/json");
            request.AddParameter("search", input);
            return request;
        }

        public bool CheckForCache(string requestParameter)
        {
            int exist=0;
            DBClient.CreateDBClient();
            DBClient.OpenConnection();

            var command = DBClient.CreateCommand();
            command.CommandText = $"set @exist = (select EXISTS(SELECT * from response WHERE" +
                $" RequestParameter='{requestParameter}') );select @exist";
            var reader = command.ExecuteReader();
            if(reader.Read())
            {
                exist = (int)(long)reader["@exist"];
            }
            reader.Close();
            DBClient.CloseConnection(); 
            if(exist==1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public Planet MakeRequest(string input)
        {
            IRestRequest request = BuildRequest(input);
            string requestParameter = request.Parameters[1].ToString();
            
            if(CheckForCache(requestParameter))
            {
                DBManager dbManager = new DBManager();
                requestAttempts = request.Attempts;
                return dbManager.SelectFromDB(requestParameter);
                
            }
            else
            {
                IDBProcessing dbManager = new DBManager();

                IRestResponse<List<Planet>> response = APIClient.client.Get<List<Planet>>(request);
                dbManager.InsertIntoDB(requestParameter,response);
                Planet planet = new Planet();
                planet = response.Data[0];
                requestAttempts = request.Attempts;

                return planet;
            } 
        }

        public Planet MakeRequest(IRestRequest request)
        {
            request.AddHeader("Accept", "application/json");
            string requestParameter = request.Parameters[1].ToString();
            if(CheckForCache(requestParameter))
            {
                DBManager dbManager = new DBManager();
                requestAttempts = request.Attempts;
                return dbManager.SelectFromDB(requestParameter);
            }
            else
            {
                IDBProcessing dbManager = new DBManager();
                IRestResponse<List<Planet>> response = APIClient.client.Get<List<Planet>>(request);
                dbManager.InsertIntoDB(requestParameter,response);

                Planet planet = new Planet();
                planet = response.Data[0];
                requestAttempts = request.Attempts;

                return planet;
            }
        }

        private int requestAttempts;
        public int GetRequestAttempts()
        {
            return requestAttempts;
        }

    }
}
