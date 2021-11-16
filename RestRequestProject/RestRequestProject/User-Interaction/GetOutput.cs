using System;

namespace RestRequestProject
{
    class GetOutput:IUserOutputProcessing
    {
        void IUserOutputProcessing.OutputToConsole(string output)
        {
            Console.WriteLine(output);
        }
    }
}
