using System;
using RestSharp;

namespace RestRequestProject
{
    //all clases are public for accessability of UnitTests;
    public static class APIClient
    {
        public static RestClient client;

        public static void CreateClient()
        {
            client = new RestClient("https://swapi.dev/api/planets");
        }

    }
}
