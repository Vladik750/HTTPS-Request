using System;
using RestSharp;

namespace RestRequestProject
{
    //all clases are public for accessability of UnitTests;
    public class Client
    {
        public RestClient client;

        public Client()
        {
            client = new RestClient("https://swapi.dev/api/people");
        }

    }
}
