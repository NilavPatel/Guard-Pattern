using System;
using System.Text.RegularExpressions;

namespace Guard_Pattern
{
    public class GuardExtensions
    {
        #region For Object
        public static Void Null<T>(this IGuardClause guardClause, T argument, string argumentName)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }
        #endregion

        #region For String
        public static Void NullOrEmpty(this IGuardClause guardClause, string argument, string argumentName)
        {
            if (string.IsNullOrEmpty(argument))
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        public static Void NullOrWhiteSpace(this IGuardClause guardClause, string argument, string argumentName)
        {
            if (string.IsNullOrWhiteSpace(argument))
            {
                throw new ArgumentNullException(argumentName);
            }
        }

        public static Void LeadingAndTailingSpace(this IGuardClause guardClause, string argument, string argumentName)
        {
            if (argument.Trim() != argument)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing leading and tailing space", argumentName));
            }
        }

        public static Void MinimumLength(this IGuardClause guardClause, string argument, string argumentName, int minLength)
        {
            if (argument.Length < minLength)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing characters less than {1}", argumentName, minLength));
            }
        }

        public static Void MaximumLength(this IGuardClause guardClause, string argument, string argumentName, int maxLength)
        {
            if (argument.Length > maxLength)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing characters more than {1}", argumentName, maxLength));
            }
        }

        public static Void SpecialCharacters(this IGuardClause guardClause, string argument, string argumentName)
        {
            if (HasSpecialChars(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing any special characters", argumentName));
            }
        }

        public static Void Digits(this IGuardClause guardClause, string argument, string argumentName)
        {
            if (HasDigits(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing any digits", argumentName));
            }
        }

        public static Void Alphabet(this IGuardClause guardClause, string argument, string argumentName)
        {
            if (HasAlphabets(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing any alphabets", argumentName));
            }
        }

        public static Void LowerCase(this IGuardClause guardClause, string argument, string argumentName)
        {
            if (HasLowerCase(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing lower case", argumentName));
            }
        }

        public static Void UpperCase(this IGuardClause guardClause, string argument, string argumentName)
        {
            if (HasUpperCase(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing upper case", argumentName));
            }
        }

        public static Void Space(this IGuardClause guardClause, string argument, string argumentName)
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
        public static Void NumberLessThan(this IGuardClause guardClause, int argument, string argumentName, int min)
        {
            if (argument < min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than {1}", argumentName, min));
            }
        }

        public static Void NumberGreaterThan(this IGuardClause guardClause, int argument, string argumentName, int max)
        {
            if (argument > max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing more than {1}", argumentName, max));
            }
        }

        public static Void NumberLessThanOrEqual(this IGuardClause guardClause, int argument, string argumentName, int min)
        {
            if (argument <= min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than or equals to {1}", argumentName, min));
            }
        }

        public static Void NumberGreaterThanOrEqual(this IGuardClause guardClause, int argument, string argumentName, int max)
        {
            if (argument >= max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing greater than or equals to {1}", argumentName, max));
            }
        }

        public static Void NumberZero(this IGuardClause guardClause, int argument, string argumentName)
        {
            if (argument == 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing 0", argumentName));
            }
        }

        public static Void NumberNegative(this IGuardClause guardClause, int argument, string argumentName)
        {
            if (argument < 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing negative value", argumentName));
            }
        }

        public static Void NumberNegativeOrZero(this IGuardClause guardClause, int argument, string argumentName)
        {
            if (argument <= 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing negative value or 0", argumentName));
            }
        }

        public static Void NumberOutOfRange(this IGuardClause guardClause, int argument, string argumentName, int startRange, int endRange)
        {
            if (argument < startRange || argument > endRange)
            {
                throw new ArgumentException(string.Format("Argument {0} is out of range", argumentName));
            }
        }
        #endregion

        #region For Double
        public static Void NumberLessThan(this IGuardClause guardClause, double argument, string argumentName, double min)
        {
            if (argument < min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than {1}", argumentName, min));
            }
        }

        public static Void NumberGreaterThan(this IGuardClause guardClause, double argument, string argumentName, double max)
        {
            if (argument > max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing more than {1}", argumentName, max));
            }
        }

        public static Void NumberLessThanOrEqual(this IGuardClause guardClause, double argument, string argumentName, double min)
        {
            if (argument <= min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than or equals to {1}", argumentName, min));
            }
        }

        public static Void NumberGreaterThanOrEqual(this IGuardClause guardClause, double argument, string argumentName, double max)
        {
            if (argument >= max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing greater than or equals to {1}", argumentName, max));
            }
        }

        public static Void NumberZero(this IGuardClause guardClause, double argument, string argumentName)
        {
            if (argument == 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing 0", argumentName));
            }
        }

        public static Void NumberNegative(this IGuardClause guardClause, double argument, string argumentName)
        {
            if (argument < 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing negative value.", argumentName));
            }
        }

        public static Void NumberNegativeOrZero(this IGuardClause guardClause, double argument, string argumentName)
        {
            if (argument <= 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing negative value or 0", argumentName));
            }
        }

        public static Void NumberOutOfRange(this IGuardClause guardClause, double argument, string argumentName, double startRange, double endRange)
        {
            if (argument < startRange || argument > endRange)
            {
                throw new ArgumentException(string.Format("Argument {0} is out of range", argumentName));
            }
        }
        #endregion

        #region For Decimal
        public static Void NumberLessThan(this IGuardClause guardClause, decimal argument, string argumentName, decimal min)
        {
            if (argument < min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than {1}", argumentName, min));
            }
        }

        public static Void NumberGreaterThan(this IGuardClause guardClause, decimal argument, string argumentName, decimal max)
        {
            if (argument > max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing more than {1}", argumentName, max));
            }
        }

        public static Void NumberLessThanOrEqual(this IGuardClause guardClause, decimal argument, string argumentName, decimal min)
        {
            if (argument <= min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than or equals to {1}", argumentName, min));
            }
        }

        public static Void NumberGreaterThanOrEqual(this IGuardClause guardClause, decimal argument, string argumentName, decimal max)
        {
            if (argument >= max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing greater than or equals to {1}", argumentName, max));
            }
        }

        public static Void NumberZero(this IGuardClause guardClause, decimal argument, string argumentName)
        {
            if (argument == 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing 0", argumentName));
            }
        }

        public static Void NumberNegative(this IGuardClause guardClause, decimal argument, string argumentName)
        {
            if (argument < 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing negative value.", argumentName));
            }
        }

        public static Void NumberNegativeOrZero(this IGuardClause guardClause, decimal argument, string argumentName)
        {
            if (argument <= 0)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing negative value or 0", argumentName));
            }
        }

        public static Void NumberOutOfRange(this IGuardClause guardClause, decimal argument, string argumentName, decimal startRange, decimal endRange)
        {
            if (argument < startRange || argument > endRange)
            {
                throw new ArgumentException(string.Format("Argument {0} is out of range", argumentName));
            }
        }
        #endregion

        #region For DateTime
        public static Void DateTimeLessThan(this IGuardClause guardClause, DateTime argument, string argumentName, DateTime min)
        {
            if (argument < min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than {1}", argumentName, min));
            }
        }

        public static Void DateTimeGreaterThan(this IGuardClause guardClause, DateTime argument, string argumentName, DateTime max)
        {
            if (argument > max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing more than {1}", argumentName, max));
            }
        }

        public static Void DateTimeLessThanOrEqual(this IGuardClause guardClause, DateTime argument, string argumentName, DateTime min)
        {
            if (argument <= min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than or equals to {1}", argumentName, min));
            }
        }

        public static Void DateTimeGreaterThanOrEqual(this IGuardClause guardClause, DateTime argument, string argumentName, DateTime max)
        {
            if (argument >= max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing greater than or equals to {1}", argumentName, max));
            }
        }

        public static Void DateTimeOutOfRange(this IGuardClause guardClause, DateTime argument, string argumentName, DateTime startRange, DateTime endRange)
        {
            if (argument < startRange || argument > endRange)
            {
                throw new ArgumentException(string.Format("Argument {0} is out of range", argumentName));
            }
        }
        #endregion

        #region For Timespan
        public static Void TimeSpanLessThan(this IGuardClause guardClause, TimeSpan argument, string argumentName, TimeSpan min)
        {
            if (argument < min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than {1}", argumentName, min));
            }
        }

        public static Void TimeSpanGreaterThan(this IGuardClause guardClause, TimeSpan argument, string argumentName, TimeSpan max)
        {
            if (argument > max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing more than {1}", argumentName, max));
            }
        }

        public static Void TimeSpanLessThanOrEqual(this IGuardClause guardClause, TimeSpan argument, string argumentName, TimeSpan min)
        {
            if (argument <= min)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing less than or equals to {1}", argumentName, min));
            }
        }

        public static Void TimeSpanGreaterThanOrEqual(this IGuardClause guardClause, TimeSpan argument, string argumentName, TimeSpan max)
        {
            if (argument >= max)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing greater than or equals to {1}", argumentName, max));
            }
        }

        public static Void TimeSpanOutOfRange(this IGuardClause guardClause, TimeSpan argument, string argumentName, TimeSpan startRange, TimeSpan endRange)
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
        public static Void InValidURL(this IGuardClause guardClause, string argument, string argumentName)
        {
            AgainstNullOrEmpty(argument, argumentName);
            if (!IsValidURL(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not valid URL", argumentName));
            }
        }

        public static Void InValidEmailId(this IGuardClause guardClause, string argument, string argumentName)
        {
            AgainstNullOrEmpty(argument, argumentName);
            if (!IsValidEmailId(argument))
            {
                throw new ArgumentException(string.Format("Argument {0} is not valid emailid", argumentName));
            }
        }

        public static Void InValidGuid(this IGuardClause guardClause, string argument, string argumentName)
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
        public static Void True(this IGuardClause guardClause, bool argument, string argumentName)
        {
            if (argument == true)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing to be true", argumentName));
            }
        }

        public static Void False(this IGuardClause guardClause, bool argument, string argumentName)
        {
            if (argument == false)
            {
                throw new ArgumentException(string.Format("Argument {0} is not allowing to be false", argumentName));
            }
        }
        #endregion
    }
}
