using System;

namespace RestRequestProject
{
    interface IUserInputProcessing
    {
        bool IsInputValid();
        bool GetUserInput(string pathToInput);
        string GetUserInput();
    }
}
