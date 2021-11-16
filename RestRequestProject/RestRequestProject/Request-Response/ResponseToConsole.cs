using System;
using RestSharp;

namespace RestRequestProject
{
    class ResponseToConsole : IShowResponse
    {
        void IShowResponse.ShowResponse(IRestResponse response)
        {
            Console.WriteLine(response.Content.ToString());
        }
    }
}
