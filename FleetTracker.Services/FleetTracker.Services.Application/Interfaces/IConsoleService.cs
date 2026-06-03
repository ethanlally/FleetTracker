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

        string PromptForVin(string prompt);
        string PromptForLicensePlate(string prompt);
        string PromptForMakeModel(string prompt);
        string PromptForDriversLicense(string prompt);
        string PromptForNameCityCountry(string prompt);
        string PromptForStreet(string prompt);
        string PromptForCreditCard(string prompt);
        string PromptForExpirationDate(string prompt);
        string PromptForCvv(string prompt);

        string PromptForOptionalVin(string prompt, string currentValue);
        string PromptForOptionalLicensePlate(string prompt, string currentValue);
        string PromptForOptionalMakeModel(string prompt, string currentValue);
        string PromptForOptionalDriversLicense(string prompt, string currentValue);
        string PromptForOptionalNameCityCountry(string prompt, string currentValue);
        string PromptForOptionalStreet(string prompt, string currentValue);
        string PromptForOptionalCreditCard(string prompt, string currentValue);
        string PromptForOptionalExpirationDate(string prompt, string currentValue);
        string PromptForOptionalCvv(string prompt, string currentValue);
    }
}