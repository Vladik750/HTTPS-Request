using System;
using System.Collections.Generic;
using System.Text;

namespace API
{
    interface IGetUserInput
    {
        bool IsInputValid();
        bool GetUserInput(string pathToInput);
        string GetUserInput();
    }
}
