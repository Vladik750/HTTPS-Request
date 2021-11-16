using System;
using RestSharp;

namespace RestRequestProject
{
    interface IBuildRequest
    {
        IRestRequest BuildRequest(IGetUserInput input, IRestRequest request);
    }
}
