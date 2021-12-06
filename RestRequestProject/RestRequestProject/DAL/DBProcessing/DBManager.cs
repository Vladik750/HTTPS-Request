using System;
using System.Collections.Generic;
using RestSharp;
using MySql.Data.MySqlClient;


namespace RestRequestProject
{
    class DBManager : IDBProcessing
    {
        public void InsertIntoDB(string requestParameter,IRestResponse<List<Planet>> response)
        {
            DBClient.CreateDBClient();
            DBClient.OpenConnection();
            DBModel dbModel = new DBModel(response);
            

            var command = DBClient.CreateCommand();
            command.CommandText = $"insert into response(RequestParameter,Name,Diameter,Climate,Gravity,Population,Time) " +
                $"values('{requestParameter}','{dbModel.GetName()}',{dbModel.GetDiameter()},'{dbModel.GetClimate()}','{dbModel.GetGravity()}',{dbModel.GetPopulation()},now());";
            command.ExecuteReader();
            DBClient.CloseConnection();
        }

        public Planet SelectFromDB(string requestParameter)
        {
            DBClient.CreateDBClient();
            var command = DBClient.CreateCommand();
            Planet planet = new Planet();
            PlanetDTO dto = new PlanetDTO();
            DBClient.OpenConnection();
            command.CommandText = $"select * from response where RequestParameter = '{requestParameter}'";
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                dto.Name =Convert.ToString( reader["Name"]);
                dto.Diameter = (float)reader["Diameter"];
                dto.Climate = Convert.ToString(reader["Climate"]);
                dto.Gravity =Convert.ToString( reader["Gravity"]);
                dto.Population = (int)reader["Population"];

                List<PlanetDTO> dtoList = new List<PlanetDTO>();
                dtoList.Add(dto);
                Planet planetTemp = new Planet(dtoList);
                planet = planetTemp;
            }
            reader.Close();
            DBClient.CloseConnection();
            return planet;

        }

       
    }
}
