using System;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;

using FleetTracker.Services.Application.Interfaces;

namespace FleetTracker.Services.Application.Services
{
    public class InputValidator : IInputValidator
    {
        public bool TryValidateString(string input, out string parsed, out string errorMsg)
        {
            parsed = input?.Trim() ?? "";
            errorMsg = "";

            if (string.IsNullOrWhiteSpace(parsed))
            {
                errorMsg = "Input cannot be null or empty.";
                return false;
            }

            string pattern = @"[^a-zA-Z0-9\s\-_.,()@+/]";
            string sanitized = Regex.Replace(parsed, pattern, "");

            if (sanitized != parsed)
            {
                errorMsg = "Input has invalid characters.";
                return false;
            }

            return true;
        }

        public bool TryValidatePhone(string phone, out string parsed, out string errorMsg)
        {
            if (!TryValidateString(phone, out parsed, out errorMsg)) return false;

            var phoneAttribute = new PhoneAttribute();
            if (!phoneAttribute.IsValid(parsed))
            {
                errorMsg = "Phone number is not in a valid format.";
                return false;
            }

            parsed = Regex.Replace(parsed, @"[^\d]", "");
            if (parsed.Length != 10)
            {
                errorMsg = "Phone number must have exactly 10 digits.";
                return false;
            }

            return true;
        }

        public bool TryValidateEmail(string email, out string parsed, out string errorMsg)
        {
            if (!TryValidateString(email, out parsed, out errorMsg)) return false;

            var emailAttribute = new EmailAddressAttribute();
            if (!emailAttribute.IsValid(parsed))
            {
                errorMsg = "Email is not in a valid format.";
                return false;
            }

            return true;
        }

        public bool TryValidateState(string state, out string parsed, out string errorMsg)
        {
            if (!TryValidateString(state, out parsed, out errorMsg)) return false;
            parsed = parsed.ToUpper();

            var states = ImmutableList.Create("AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "IA",
                "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE",
                "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT",
                "WA", "WI", "WV", "WY");

            string p = parsed;
            if (!states.Any(s => s.Equals(p, StringComparison.OrdinalIgnoreCase)))
            {
                errorMsg = "State abbreviation not recognized.";
                return false;
            }

            return true;
        }

        public bool TryValidateZip(string zip, out string parsed, out string errorMsg)
        {
            if (!TryValidateString(zip, out parsed, out errorMsg)) return false;

            if (!Regex.IsMatch(parsed, @"^\d{5}(-\d{4})?$"))
            {
                errorMsg = "Zip code is not in a valid format.";
                return false;
            }

            return true;
        }

        public bool TryValidateInt(string input, out int parsed, out string errorMsg)
        {
            errorMsg = "";
            parsed = 0;
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out parsed) || parsed < 0)
            {
                errorMsg = "Must be a valid positive integer.";
                return false;
            }
            return true;
        }

        public bool TryValidateDecimal(string input, out decimal parsed, out string errorMsg)
        {
            errorMsg = "";
            parsed = 0m;
            if (string.IsNullOrWhiteSpace(input) || !decimal.TryParse(input, out parsed) || parsed < 0)
            {
                errorMsg = "Must be a valid positive decimal.";
                return false;
            }
            return true;
        }

        public bool TryValidateDate(string input, out DateTime parsed, out string errorMsg)
        {
            errorMsg = "";
            parsed = DateTime.MinValue;
            if (string.IsNullOrWhiteSpace(input) || !DateTime.TryParse(input, out parsed))
            {
                errorMsg = "Invalid date format.";
                return false;
            }
            return true;
        }
    }
}