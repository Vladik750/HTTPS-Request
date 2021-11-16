using System;
using System.IO;

namespace RestRequestProject
{
    class GetInput:IUserInputProcessing
    {
        public string inputString;

        string IUserInputProcessing.GetUserConsoleInput()
        {
            return inputString = Console.ReadLine();
        }

        string IUserInputProcessing.GetUserFileInput(string path)
        {
            StreamReader reader = new StreamReader(path);
            inputString = reader.ReadLine();
            reader.Close();
            return inputString;
        }

        string IUserInputProcessing.GetUserInput(string input)
        {
            return inputString = input;
        }

        bool IUserInputProcessing.IsInputValid()
        {
            return true;
        }
    }
}
