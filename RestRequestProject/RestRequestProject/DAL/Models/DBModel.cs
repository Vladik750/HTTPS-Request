using System;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestRequestProject
{
    class DBModel
    {
        public static int responseId = 0;
        private string name;
        private float diameter;
        private string climate;
        private string gravity;
        private int population;

        public DBModel(IRestResponse<List<Planet>> response)
        {
            responseId++;
            this.name = response.Data[0].Results[0].Name;
            this.diameter = response.Data[0].Results[0].Diameter;
            this.climate = response.Data[0].Results[0].Climate;
            this.gravity = response.Data[0].Results[0].Gravity;
            this.population = response.Data[0].Results[0].Population;
        }

        //Getters as soon as fileds should be private to save immutability of an instance.
        //ResponseId is a static filed, so it can be accesed without getter.
        public string GetName()
        {
            return this.name;
        }
        public float GetDiameter()
        {
            return this.diameter;
        }
        public string GetClimate()
        {
            return this.climate;
        }
        public string GetGravity()
        {
            return this.gravity;
        }
        public int GetPopulation()
        {
            return this.population;
        }
    }
}
