using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examination_System
{
    public static class Utility
    {
        // Check if a string is a valid number
        public static bool IsNumber(string input)
        {
            return double.TryParse(input, out _);
        }

        // Validate email format
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        // Check if a number is positive
        public static bool IsPositive(int number)
        {
            return number > 0;
        }

        // Check if a number is negative
        public static bool IsNegative(int number)
        {
            return number < 0;
        }

        // Check if a number is within a specified range
        public static bool IsInRange(int number, int min, int max)
        {
            return number >= min && number <= max;
        }

        // Validate phone number (basic pattern)
        public static bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            string pattern = @"^\+?[1-9]\d{1,14}$"; // E.164 format (International)
            return Regex.IsMatch(phone, pattern);
        }

        // Check if a string contains only alphanumeric characters
        public static bool IsAlphanumeric(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            return Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
        }

        // Validate if the string is a valid date
        public static bool IsValidDate(string date)
        {
            return DateTime.TryParse(date, out _);
        }

        // Check if a string has a minimum length
        public static bool HasMinimumLength(string input, int length)
        {
            return !string.IsNullOrEmpty(input) && input.Length >= length;
        }

        // Check if a string is null or empty
        public static bool IsNullOrEmpty(string input)
        {
            return string.IsNullOrEmpty(input);
        }
    }
}
