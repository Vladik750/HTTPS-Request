using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace API
{
    class Client
    {
        public RestClient client;

        public Client()
        {
            client = new RestClient("https://swapi.dev/api/people");
        }
        
    }
}
