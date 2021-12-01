using System;
using System.Collections.Generic;


namespace RestRequestProject
{
    //serialization JSON property from response 
    public class Planet
    {
        public List<PlanetDTO> Results { get; set; }    
        public void Show()
        {
            for(int i=0;i<Results.Count;i++)
            {
                Results[i].ShowPlanetToConsole();
            }
        }
    }

    //serialization JSON array objects into DTO
    public class PlanetDTO
    {
        public string Name { get; set; }
        public double Diameter { get; set; }
        public string Climate { get; set; }
        public string Gravity { get; set; }
        public double Population { get; set; }

        public void ShowPlanetToConsole()
        {
            Console.WriteLine("Planet");
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Diameter: " + this.Diameter);
            Console.WriteLine("Climate: " + this.Climate);
            Console.WriteLine("Gravity: " + this.Gravity);
            Console.WriteLine("Population: " + this.Population);
        }

    }
}
