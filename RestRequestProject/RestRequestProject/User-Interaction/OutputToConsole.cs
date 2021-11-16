using System;

namespace RestRequestProject
{
    class OutputToConsole:IUserOutputProcessing
    {
        void IUserOutputProcessing.Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}
