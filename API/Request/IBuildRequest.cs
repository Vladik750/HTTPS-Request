using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace API
{
    interface IBuildRequest
    {
        IRestRequest BuildRequest(IGetUserInput input, IRestRequest request);
    }
}
