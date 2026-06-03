using System;

using FleetTracker.Services.Application.Interfaces;

namespace FleetTracker.Services.Application.Services
{
    public class ConsoleService : IConsoleService
    {
        private readonly IInputValidator _validator;

        private delegate bool ValidatorDelegate<T>(string input, out T parsed, out string errorMsg);

        public ConsoleService(IInputValidator validator)
        {
            _validator = validator;
        }

        public void WriteLine(string message = "") => Console.WriteLine(message);
        public void Write(string message) => Console.Write(message);
        public string ReadLine() => Console.ReadLine() ?? "";
        public void Clear() => Console.Clear();

        private T PromptWithValidation<T>(string prompt, ValidatorDelegate<T> validateMethod, string retryPromptSuffix = "Try again: ")
        {
            Console.Write(prompt);
            string input = ReadLine();
            T parsed;
            string error;
            while (!validateMethod(input, out parsed, out error))
            {
                Console.Write($"{error} {retryPromptSuffix}");
                input = ReadLine();
            }
            return parsed;
        }

        private T PromptForOptionalWithValidation<T>(string prompt, T currentValue, ValidatorDelegate<T> validateMethod, string retryPromptSuffix = "Try again: ")
        {
            Console.Write(prompt);
            string input = ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return currentValue;
            
            T parsed;
            string error;
            while (!validateMethod(input, out parsed, out error))
            {
                Console.Write($"{error} {retryPromptSuffix}");
                input = ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return currentValue;
            }
            return parsed;
        }

        // --- Required Prompts ---

        public string PromptForInput(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateString);
        public string PromptForPhone(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidatePhone);
        public string PromptForEmail(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateEmail);
        public string PromptForState(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateState);
        public string PromptForZip(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateZip);
        public int PromptForInt(string prompt) => PromptWithValidation<int>(prompt, _validator.TryValidateInt);
        public decimal PromptForDecimal(string prompt) => PromptWithValidation<decimal>(prompt, _validator.TryValidateDecimal);
        public DateTime PromptForDate(string prompt) => PromptWithValidation<DateTime>(prompt, _validator.TryValidateDate, "Try again (yyyy-mm-dd): ");

        public string PromptForVin(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateVin);
        public string PromptForLicensePlate(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateLicensePlate);
        public string PromptForMakeModel(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateMakeModel);
        public string PromptForDriversLicense(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateDriversLicense);
        public string PromptForNameCityCountry(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateNameCityCountry);
        public string PromptForStreet(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateStreet);
        public string PromptForCreditCard(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateCreditCard);
        public string PromptForExpirationDate(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateExpirationDate);
        public string PromptForCvv(string prompt) => PromptWithValidation<string>(prompt, _validator.TryValidateCvv);

        // --- Optional Prompts ---

        public string PromptForOptionalInput(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateString);
        public string PromptForOptionalPhone(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidatePhone);
        public string PromptForOptionalEmail(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateEmail);
        public string PromptForOptionalState(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateState);
        public string PromptForOptionalZip(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateZip);
        public int PromptForOptionalInt(string prompt, int cv) => PromptForOptionalWithValidation<int>(prompt, cv, _validator.TryValidateInt);
        public decimal PromptForOptionalDecimal(string prompt, decimal cv) => PromptForOptionalWithValidation<decimal>(prompt, cv, _validator.TryValidateDecimal);
        public DateTime PromptForOptionalDate(string prompt, DateTime cv) => PromptForOptionalWithValidation<DateTime>(prompt, cv, _validator.TryValidateDate, "Try again (yyyy-mm-dd): ");

        public string PromptForOptionalVin(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateVin);
        public string PromptForOptionalLicensePlate(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateLicensePlate);
        public string PromptForOptionalMakeModel(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateMakeModel);
        public string PromptForOptionalDriversLicense(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateDriversLicense);
        public string PromptForOptionalNameCityCountry(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateNameCityCountry);
        public string PromptForOptionalStreet(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateStreet);
        public string PromptForOptionalCreditCard(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateCreditCard);
        public string PromptForOptionalExpirationDate(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateExpirationDate);
        public string PromptForOptionalCvv(string prompt, string cv) => PromptForOptionalWithValidation<string>(prompt, cv, _validator.TryValidateCvv);
    }
}