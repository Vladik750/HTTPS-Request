using RestSharp;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace RestRequestProject
{
    public static class DBClient
    {
        public static MySqlConnection connection;

        public static void  CreateDBClient()
        {
            if(DBClient.connection == null)
            {
                var sb = new MySqlConnectionStringBuilder
                {
                    Server = "localhost",
                    UserID = "root",
                    Password = "Vladislav24",
                    Port = 3306,
                    Database = "responsesdb"
                };
                sb.AllowUserVariables=true;
                connection = new MySqlConnection(sb.ConnectionString);
            }
            
        }

    }
}
