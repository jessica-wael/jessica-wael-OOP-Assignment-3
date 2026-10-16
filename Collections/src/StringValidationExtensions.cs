using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CollectionsLab
{
    public static class StringValidationExtensions
    {
        // (010 , 012 , 015, 011) + 8digits is true or the same num with +20 is valid
        //

        private static readonly Regex PhoneNumber = new Regex(@"^(01[0125]\d{8}|\+201[0125]\d{8})$", RegexOptions.Compiled);

        // Exactly 14 digits... first digit 2 or 3
        private static readonly Regex NationalId = new Regex(@"^([23]\d{13})$", RegexOptions.Compiled);

        public static bool IsValidEgyptianPhone(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) { return false; }

            return PhoneNumber.IsMatch(value);
        }

        public static bool IsValidEgyptianNationalId(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) { return false; }

            return NationalId.IsMatch(value);
        }

        public static string? GetEgyptianPhoneError(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "null, empty, or spaces";

           
            if (value.IsValidEgyptianPhone())
                return null;

            if (value.Length != 11)
                return $"only {value.Length} digit";

            if(! value.All(char.IsAsciiDigit))
                return "contains a letter";

            string prefix = value.Substring(0, 3);
            if (prefix != "010" && prefix != "011" && prefix != "012" && prefix != "015")
                return $"{prefix} is not a valid prefix";

            return null;

            
        }

        public static string? GetNationalIdError(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "null, empty, or spaces";


            if (value.IsValidEgyptianNationalId())
                return null;

            if (value.Length != 14)
                return $"only {value.Length} digit";

            if (!value.All(char.IsAsciiDigit))
                return "contains a letter";

            string prefix = value.Substring(0,1);
            if (prefix != "2" && prefix != "3" )
                return "must start with 2 or 3";

            return null;


        }


    }
}
