using System;
//using MySqlConnector;
using RestSharp;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace RestRequestProject
{
    class DBClient
    {
        private MySqlConnection connection;

        public DBClient()
        {/*@localhost*/
            /*this.connectionString = "server=localhost;user=root;password=Vladislav24;database=responsesdb";
            connection = new MySqlConnection(connectionString);*/
            var sb = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",//@localhost
                Password = "Vladislav24",
                Port = 3306,
                Database = "responsesdb"
            };

            connection = new MySqlConnection(sb.ConnectionString);
        }

        public void PushResponseToDB(IRestResponse<List<Planet>> response)
        {
            connection.Open();
            DBModel dbModel = new DBModel(response);

            var command = connection.CreateCommand();
            command.CommandText = $"insert into response(ResponseId,Name,Diameter,Climate,Gravity,Population,Time) " +
                $"values({DBModel.responseId},'{dbModel.GetName()}',{dbModel.GetDiameter()},'{dbModel.GetClimate()}','{dbModel.GetGravity()}',{dbModel.GetPopulation()},now());";
            command.ExecuteReader();

            /*command.CommandText = "select ResponseId from response where Name ='name2'; ";
            var reader = command.ExecuteReader();
            if(reader.Read())
            {
                Console.WriteLine(String.Format("{0}", reader["ResponseId"]));
            }*/
            connection.Close();
            
        }
    }
}
