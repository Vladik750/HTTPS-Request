using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    class GetConsoleInput:IGetUserInput
    {
        public string inputString;

        //constructor that reads from console
        public GetConsoleInput()
        {
            inputString = Console.ReadLine();
        }
        bool IGetUserInput.GetUserInput(string pathToInput)
        {
            throw new NotImplementedException();
        }

        string IGetUserInput.GetUserInput()
        {
            return inputString;
        }

        bool IGetUserInput.IsInputValid()
        {
            throw new NotImplementedException();
        }
    }
}
