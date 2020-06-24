﻿using System;
using System.Text.RegularExpressions;

namespace Guard_Pattern
{
    /// <summary>
    /// The Guard class, which contains basic methods for object, string, int, double, decimal, datetime, timespan, URL, bool validations.    
    /// </summary>
    public static class Guard
    {
        #region For Object
        public static void AgainstNull(object argument, string argumentName)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }
        #endregion

        #region For String
        public static void AgainstNullOrEmpty(string argument, string argumentName)
        {
            if (string.IsNullOrEmpty(argument))
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        public static void AgainstNullOrWhiteSpace(string argument, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(argument))
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        public static void AgainstLeadingAndTailingSpace(string argument, string argumentName)
        {
            if (argument.Trim() != argument)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing leading and tailing space", argumentName));
            }
        }

        public static void AgainstMinimumLength(string argument, string argumentName, int minLength)
        {
            if (argument.Length < minLength)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing characters less than {1}", argumentName, minLength));
            }
        }

        public static void AgainstMaximumLength(string argument, string argumentName, int maxLength)
        {
            if (argument.Length > maxLength)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing characters more than {1}", argumentName, maxLength));
            }
        }

        public static void AgainstSpecialCharacters(string argument, string argumentName)
        {
            if (HasSpecialChars(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing any special characters", argumentName));
            }
        }

        public static void AgainstDigits(string argument, string argumentName)
        {
            if (HasDigits(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing any digits", argumentName));
            }
        }

        public static void AgainstAlphabet(string argument, string argumentName)
        {
            if (HasAlphabets(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing any alphabets", argumentName));
            }
        }

        public static void AgainstLowerCase(string argument, string argumentName)
        {
            if (HasLowerCase(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing lower case", argumentName));
            }
        }

        public static void AgainstUpperCase(string argument, string argumentName)
        {
            if (HasUpperCase(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing upper case", argumentName));
            }
        }

        public static void AgainstSpace(string argument, string argumentName)
        {
            if (argument.Contains(" "))
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing space", argumentName));
            }
        }

        private static bool HasSpecialChars(string value)
        {
            Regex rx = new Regex(@"[~`!@#$%^&*()-+=|\{}':;.,<>/?]");
            if (rx.IsMatch(value))
            {
                return true;
            }
            return false;
        }

        private static bool HasDigits(string value)
        {
            Regex rx = new Regex(@"[0-9]");
            if (rx.IsMatch(value))
            {
                return true;
            }
            return false;
        }

        private static bool HasAlphabets(string value)
        {
            Regex rx = new Regex(@"[a-zA-Z]");
            if (rx.IsMatch(value))
            {
                return true;
            }
            return false;
        }

        private static bool HasUpperCase(string value)
        {
            Regex rx = new Regex(@"[A-Z]");
            if (rx.IsMatch(value))
            {
                return true;
            }
            return false;
        }

        private static bool HasLowerCase(string value)
        {
            Regex rx = new Regex(@"[a-z]");
            if (rx.IsMatch(value))
            {
                return true;
            }
            return false;
        }
        #endregion

        #region For Integer
        public static void AgainstNumberLessThan(int argument, string argumentName, int min)
        {
            if (argument < min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than {1}", argumentName, min));
            }
        }

        public static void AgainstNumberGreaterThan(int argument, string argumentName, int max)
        {
            if (argument > max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing more than {1}", argumentName, max));
            }
        }

        public static void AgainstNumberLessThanOrEqual(int argument, string argumentName, int min)
        {
            if (argument <= min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than or equals to {1}", argumentName, min));
            }
        }

        public static void AgainstNumberGreaterThanOrEqual(int argument, string argumentName, int max)
        {
            if (argument >= max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing greater than or equals to {1}", argumentName, max));
            }
        }

        public static void AgainstNumberZero(int argument, string argumentName)
        {
            if (argument == 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing 0", argumentName));
            }
        }

        public static void AgainstNumberNegative(int argument, string argumentName)
        {
            if (argument < 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing negative value", argumentName));
            }
        }

        public static void AgainstNumberNegativeOrZero(int argument, string argumentName)
        {
            if (argument <= 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing negative value or 0", argumentName));
            }
        }

        public static void AgainstNumberOutOfRange(int argument, string argumentName, int startRange, int endRange)
        {
            if (argument < startRange || argument > endRange)
            {
                throw new ArgumentException(string.Format("Argument {0} is out of range", argumentName));
            }
        }
        #endregion

        #region For Double
        public static void AgainstNumberLessThan(double argument, string argumentName, double min)
        {
            if (argument < min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than {1}", argumentName, min));
            }
        }

        public static void AgainstNumberGreaterThan(double argument, string argumentName, double max)
        {
            if (argument > max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing more than {1}", argumentName, max));
            }
        }

        public static void AgainstNumberLessThanOrEqual(double argument, string argumentName, double min)
        {
            if (argument <= min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than or equals to {1}", argumentName, min));
            }
        }

        public static void AgainstNumberGreaterThanOrEqual(double argument, string argumentName, double max)
        {
            if (argument >= max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing greater than or equals to {1}", argumentName, max));
            }
        }

        public static void AgainstNumberZero(double argument, string argumentName)
        {
            if (argument == 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing 0", argumentName));
            }
        }

        public static void AgainstNumberNegative(double argument, string argumentName)
        {
            if (argument < 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing negative value.", argumentName));
            }
        }

        public static void AgainstNumberNegativeOrZero(double argument, string argumentName)
        {
            if (argument <= 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing negative value or 0", argumentName));
            }
        }

        public static void AgainstNumberOutOfRange(double argument, string argumentName, double startRange, double endRange)
        {
            if (argument < startRange || argument > endRange)
            {
                throw new ArgumentException(string.Format("Argument {0} is out of range", argumentName));
            }
        }
        #endregion

        #region For Decimal
        public static void AgainstNumberLessThan(decimal argument, string argumentName, decimal min)
        {
            if (argument < min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than {1}", argumentName, min));
            }
        }

        public static void AgainstNumberGreaterThan(decimal argument, string argumentName, decimal max)
        {
            if (argument > max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing more than {1}", argumentName, max));
            }
        }

        public static void AgainstNumberLessThanOrEqual(decimal argument, string argumentName, decimal min)
        {
            if (argument <= min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than or equals to {1}", argumentName, min));
            }
        }

        public static void AgainstNumberGreaterThanOrEqual(decimal argument, string argumentName, decimal max)
        {
            if (argument >= max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing greater than or equals to {1}", argumentName, max));
            }
        }

        public static void AgainstNumberZero(decimal argument, string argumentName)
        {
            if (argument == 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing 0", argumentName));
            }
        }

        public static void AgainstNumberNegative(decimal argument, string argumentName)
        {
            if (argument < 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing negative value.", argumentName));
            }
        }

        public static void AgainstNumberNegativeOrZero(decimal argument, string argumentName)
        {
            if (argument <= 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing negative value or 0", argumentName));
            }
        }

        public static void AgainstNumberOutOfRange(decimal argument, string argumentName, decimal startRange, decimal endRange)
        {
            if (argument < startRange || argument > endRange)
            {
                throw new ArgumentException(string.Format("Argument {0} is out of range", argumentName));
            }
        }
        #endregion

        #region For DateTime
        public static void AgainstDateTimeLessThan(DateTime argument, string argumentName, DateTime min)
        {
            if (argument < min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than {1}", argumentName, min));
            }
        }

        public static void AgainstDateTimeGreaterThan(DateTime argument, string argumentName, DateTime max)
        {
            if (argument > max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing more than {1}", argumentName, max));
            }
        }

        public static void AgainstDateTimeLessThanOrEqual(DateTime argument, string argumentName, DateTime min)
        {
            if (argument <= min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than or equals to {1}", argumentName, min));
            }
        }

        public static void AgainstDateTimeGreaterThanOrEqual(DateTime argument, string argumentName, DateTime max)
        {
            if (argument >= max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing greater than or equals to {1}", argumentName, max));
            }
        }

        public static void AgainstDateTimeOutOfRange(DateTime argument, string argumentName, DateTime startRange, DateTime endRange)
        {
            if (argument < startRange || argument > endRange)
            {
                throw new ArgumentException(string.Format("Argument {0} is out of range", argumentName));
            }
        }
        #endregion

        #region For Timespan
        public static void AgainstTimeSpanLessThan(TimeSpan argument, string argumentName, TimeSpan min)
        {
            if (argument < min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than {1}", argumentName, min));
            }
        }

        public static void AgainstTimeSpanGreaterThan(TimeSpan argument, string argumentName, TimeSpan max)
        {
            if (argument > max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing more than {1}", argumentName, max));
            }
        }

        public static void AgainstTimeSpanLessThanOrEqual(TimeSpan argument, string argumentName, TimeSpan min)
        {
            if (argument <= min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than or equals to {1}", argumentName, min));
            }
        }

        public static void AgainstTimeSpanGreaterThanOrEqual(TimeSpan argument, string argumentName, TimeSpan max)
        {
            if (argument >= max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing greater than or equals to {1}", argumentName, max));
            }
        }

        public static void AgainstTimeSpanOutOfRange(TimeSpan argument, string argumentName, TimeSpan startRange, TimeSpan endRange)
        {
            if (argument < startRange || argument > endRange)
            {
                throw new ArgumentException(string.Format("Argument {0} is out of range", argumentName));
            }
        }
        #endregion

        #region For Others

        /// <summary>
        /// Only Absolute URLs are validated.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static void AgainstInValidURL(string argument, string argumentName)
        {
            AgainstNullOrEmpty(argument, argumentName);
            if (!IsValidURL(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not valid URL", argumentName));
            }
        }

        public static void AgainstInValidEmailId(string argument, string argumentName)
        {
            AgainstNullOrEmpty(argument, argumentName);
            if (!IsValidEmailId(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not valid emailid", argumentName));
            }
        }

        public static void AgainstInValidGuid(string argument, string argumentName)
        {
            AgainstNullOrEmpty(argument, argumentName);
            if (!IsValidGuid(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not valid Guid", argumentName));
            }
        }

        private static bool IsValidURL(string value)
        {
            Uri result;
            return Uri.TryCreate(value, UriKind.Absolute, out result) &&
                   (result.Scheme == "http" || result.Scheme == "https");
        }

        private static bool IsValidEmailId(string value)
        {
            return Regex.IsMatch(value,
               @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
               @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
               RegexOptions.IgnoreCase);
        }

        private static bool IsValidGuid(string value)
        {
            Guid result;
            return Guid.TryParse(value, out result);
        }
        #endregion

        #region For bool
        public static void AgainstTrue(bool argument, string argumentName)
        {
            if (argument == true)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing to be true", argumentName));
            }
        }

        public static void AgainstFalse(bool argument, string argumentName)
        {
            if (argument == false)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing to be false", argumentName));
            }
        }
        #endregion
    }
}
