using System;
using RestSharp;

namespace RestRequestProject
{
    class Client
    {
        public /*static*/ RestClient client;

        public Client()
        {
            client = new RestClient("https://swapi.dev/api/people");
        }

    }
}
