using RestSharp;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace RestRequestProject
{
    public static class DBClient
    {
        private static MySqlConnection connection;

        public static void  CreateDBClient()
        {
            if(DBClient.connection == null)
            {
                var sb = new MySqlConnectionStringBuilder
                {
                    Server = "localhost",
                    UserID = "root",
                    Password = "Vlghir9og9u9",
                    Port = 3306,
                    Database = "mydb"
                };
                sb.AllowUserVariables=true;
                connection = new MySqlConnection(sb.ConnectionString);
            }
            
        }

        public static void OpenConnection()
        {
            connection.Open();
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

        public static MySqlCommand CreateCommand()
        {
            var command = DBClient.connection.CreateCommand();
            return command;
        }

    }
}
