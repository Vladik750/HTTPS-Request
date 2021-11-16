using System;
using RestSharp;

namespace RestRequestProject
{
    interface IShowResponse
    {
        void ShowResponse(IRestResponse response);
    }
}
