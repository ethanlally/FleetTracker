using System;

namespace FleetTracker.Services.Application.Interfaces
{
    public interface IInputValidator
    {
        bool TryValidateString(string input, out string parsed, out string errorMsg);
        bool TryValidatePhone(string input, out string parsed, out string errorMsg);
        bool TryValidateEmail(string input, out string parsed, out string errorMsg);
        bool TryValidateState(string input, out string parsed, out string errorMsg);
        bool TryValidateZip(string input, out string parsed, out string errorMsg);
        bool TryValidateInt(string input, out int parsed, out string errorMsg);
        bool TryValidateDecimal(string input, out decimal parsed, out string errorMsg);
        bool TryValidateDate(string input, out DateTime parsed, out string errorMsg);
        bool TryValidateVin(string input, out string parsed, out string errorMsg);
        bool TryValidateLicensePlate(string input, out string parsed, out string errorMsg);
        bool TryValidateMakeModel(string input, out string parsed, out string errorMsg);
        bool TryValidateDriversLicense(string input, out string parsed, out string errorMsg);
        bool TryValidateNameCityCountry(string input, out string parsed, out string errorMsg);
        bool TryValidateStreet(string input, out string parsed, out string errorMsg);
        bool TryValidateCreditCard(string input, out string parsed, out string errorMsg);
        bool TryValidateExpirationDate(string input, out string parsed, out string errorMsg);
        bool TryValidateCvv(string input, out string parsed, out string errorMsg);
    }
}