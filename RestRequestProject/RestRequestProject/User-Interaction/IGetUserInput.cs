using System;

namespace RestRequestProject
{
    interface IGetUserInput
    {
        bool IsInputValid();
        bool GetUserInput(string pathToInput);
        string GetUserInput();
    }
}
