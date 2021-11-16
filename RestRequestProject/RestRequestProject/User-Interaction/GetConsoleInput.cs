using System;

namespace RestRequestProject
{
    class GetConsoleInput:IUserInputProcessing
    {
        public string inputString;

        //constructor that reads from console
        public GetConsoleInput()
        {
            inputString = Console.ReadLine();
        }
        bool IUserInputProcessing.GetUserInput(string pathToInput)
        {
            throw new NotImplementedException();
        }

        string IUserInputProcessing.GetUserInput()
        {
            return inputString;
        }

        bool IUserInputProcessing.IsInputValid()
        {
            throw new NotImplementedException();
        }
    }
}
