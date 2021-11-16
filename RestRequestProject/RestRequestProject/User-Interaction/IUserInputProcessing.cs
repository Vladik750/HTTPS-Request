using System;

namespace RestRequestProject
{
    public interface IUserInputProcessing
    {
        bool IsInputValid();
        string GetUserConsoleInput();
        string GetUserFileInput(string path);
        string GetUserInput(string input);
        
        
    }
}
