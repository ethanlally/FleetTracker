using System;

namespace FleetTracker.Services.Application.Interfaces
{
    public interface IConsoleService
    {
        void WriteLine(string message = "");
        void Write(string message);
        string ReadLine();
        void Clear();

        string PromptForInput(string prompt);
        string PromptForPhone(string prompt);
        string PromptForEmail(string prompt);
        string PromptForState(string prompt);
        string PromptForZip(string prompt);
        int PromptForInt(string prompt);
        decimal PromptForDecimal(string prompt);
        DateTime PromptForDate(string prompt);

        string PromptForOptionalInput(string prompt, string currentValue);
        string PromptForOptionalPhone(string prompt, string currentValue);
        string PromptForOptionalEmail(string prompt, string currentValue);
        string PromptForOptionalState(string prompt, string currentValue);
        string PromptForOptionalZip(string prompt, string currentValue);
        int PromptForOptionalInt(string prompt, int currentValue);
        decimal PromptForOptionalDecimal(string prompt, decimal currentValue);
        DateTime PromptForOptionalDate(string prompt, DateTime currentValue);
    }
}