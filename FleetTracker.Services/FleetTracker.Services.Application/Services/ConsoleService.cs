using System;

using FleetTracker.Services.Application.Interfaces;

namespace FleetTracker.Services.Application.Services
{
    public class ConsoleService : IConsoleService
    {
        private readonly IInputValidator _validator;

        public ConsoleService(IInputValidator validator)
        {
            _validator = validator;
        }

        public void WriteLine(string message = "") => Console.WriteLine(message);
        public void Write(string message) => Console.Write(message);
        public string ReadLine() => Console.ReadLine() ?? "";
        public void Clear() => Console.Clear();

        public string PromptForInput(string prompt)
        {
            Console.Write(prompt);
            string input = ReadLine();
            string parsed;
            string error;
            // validating user input to ensure it meets format requirements, will keep prompting until a valid entry is provided
            while (!_validator.TryValidateString(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
            }
            return parsed;
        }

        public string PromptForPhone(string prompt)
        {
            Console.Write(prompt);
            string input = ReadLine();
            string parsed;
            string error;
            while (!_validator.TryValidatePhone(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
            }
            return parsed;
        }

        public string PromptForEmail(string prompt)
        {
            Console.Write(prompt);
            string input = ReadLine();
            string parsed;
            string error;
            while (!_validator.TryValidateEmail(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
            }
            return parsed;
        }

        public string PromptForState(string prompt)
        {
            Console.Write(prompt);
            string input = ReadLine();
            string parsed;
            string error;
            while (!_validator.TryValidateState(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
            }
            return parsed;
        }

        public string PromptForZip(string prompt)
        {
            Console.Write(prompt);
            string input = ReadLine();
            string parsed;
            string error;
            while (!_validator.TryValidateZip(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
            }
            return parsed;
        }

        public int PromptForInt(string prompt)
        {
            Console.Write(prompt);
            string input = ReadLine();
            int parsed;
            string error;
            while (!_validator.TryValidateInt(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
            }
            return parsed;
        }

        public decimal PromptForDecimal(string prompt)
        {
            Console.Write(prompt);
            string input = ReadLine();
            decimal parsed;
            string error;
            while (!_validator.TryValidateDecimal(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
            }
            return parsed;
        }

        public DateTime PromptForDate(string prompt)
        {
            Console.Write(prompt);
            string input = ReadLine();
            DateTime parsed;
            string error;
            while (!_validator.TryValidateDate(input, out parsed, out error))
            {
                Console.Write($"{error} Try again (yyyy-mm-dd): ");
                input = ReadLine();
            }
            return parsed;
        }

        // prompting for optional field update - if input is left blank then existing value is retained
        public string PromptForOptionalInput(string prompt, string currentValue)
        {
            Console.Write(prompt);
            string input = ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return currentValue;
            string parsed; string error;
            while (!_validator.TryValidateString(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return currentValue;
            }
            return parsed;
        }

        public string PromptForOptionalPhone(string prompt, string currentValue)
        {
            Console.Write(prompt);
            string input = ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return currentValue;
            string parsed; string error;
            while (!_validator.TryValidatePhone(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return currentValue;
            }
            return parsed;
        }

        public string PromptForOptionalEmail(string prompt, string currentValue)
        {
            Console.Write(prompt);
            string input = ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return currentValue;
            string parsed; string error;
            while (!_validator.TryValidateEmail(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return currentValue;
            }
            return parsed;
        }

        public string PromptForOptionalState(string prompt, string currentValue)
        {
            Console.Write(prompt);
            string input = ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return currentValue;
            string parsed; string error;
            while (!_validator.TryValidateState(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return currentValue;
            }
            return parsed;
        }

        public string PromptForOptionalZip(string prompt, string currentValue)
        {
            Console.Write(prompt);
            string input = ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return currentValue;
            string parsed; string error;
            while (!_validator.TryValidateZip(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return currentValue;
            }
            return parsed;
        }

        public int PromptForOptionalInt(string prompt, int currentValue)
        {
            Console.Write(prompt);
            string input = ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return currentValue;
            int parsed; string error;
            while (!_validator.TryValidateInt(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return currentValue;
            }
            return parsed;
        }

        public decimal PromptForOptionalDecimal(string prompt, decimal currentValue)
        {
            Console.Write(prompt);
            string input = ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return currentValue;
            decimal parsed; string error;
            while (!_validator.TryValidateDecimal(input, out parsed, out error))
            {
                Console.Write($"{error} Try again: ");
                input = ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return currentValue;
            }
            return parsed;
        }

        public DateTime PromptForOptionalDate(string prompt, DateTime currentValue)
        {
            Console.Write(prompt);
            string input = ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return currentValue;
            DateTime parsed; string error;
            while (!_validator.TryValidateDate(input, out parsed, out error))
            {
                Console.Write($"{error} Try again (yyyy-mm-dd): ");
                input = ReadLine();
                if (string.IsNullOrWhiteSpace(input)) return currentValue;
            }
            return parsed;
        }
    }
}
