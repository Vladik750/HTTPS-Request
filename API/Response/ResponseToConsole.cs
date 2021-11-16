using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace API
{
    class ResponseToConsole : IShowResponse
    {
        void IShowResponse.ShowResponse(IRestResponse response)
        {
            Console.WriteLine(response.Content.ToString());
        }
    }
}
