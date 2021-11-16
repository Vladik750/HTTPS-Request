using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace API
{
    interface IShowResponse
    {
        void ShowResponse(IRestResponse response);
    }
}
