# C# Guard Pattern

## Guard validation clause list for object, string, int, double, decimal, datetime, timespan, URL.

### Examples

````javascript

Guard.AgainstNull(name, "Name");

Guard.AgainstNullOrEmpty(name, "Name");

Guard.AgainstMinimumLength(name, "Name", 10);

Guard.AgainstNumberLessThan(money, "Money", 1000);

Guard.AgainstNumberGreaterThanOrEqual(money, "Money", 1000);

Guard.AgainstNumberNegative(money, "Money");

Guard.AgainstDateTimeGreaterThan(startDate, "StartDate", DateTime.Now);

Guard.AgainstInValidURL("https://nilavpatel.github.io", "URL");

````

### For Object
- AgainstNull


### For String
- AgainstNullOrEmpty
- AgainstNullOrWhiteSpace
- AgainstLeadingAndTailingSpace
- AgainstMinimumLength
- AgainstMaximumLength
- AgainstSpecialCharacters
- AgainstDigits
- AgainstAlphabet
- AgainstLowerCase
- AgainstUpperCase
- AgainstSpace


### For int, double, decimal
- AgainstNumberLessThan
- AgainstNumberGreaterThan
- AgainstNumberLessThanOrEqual
- AgainstNumberGreaterThanOrEqual
- AgainstNumberZero
- AgainstNumberNegative
- AgainstNumberNegativeOrZero
- AgainstNumberOutOfRange


### For DateTime
- AgainstDateTimeLessThan
- AgainstDateTimeGreaterThan
- AgainstDateTimeLessThanOrEqual
- AgainstDateTimeGreaterThanOrEqual
- AgainstDateTimeOutOfRange

### For TimeSpan
- AgainstTimeSpanLessThan
- AgainstTimeSpanGreaterThan
- AgainstTimeSpanLessThanOrEqual
- AgainstTimeSpanGreaterThanOrEqual
- AgainstTimeSpanOutOfRange

### For Others
- AgainstInValidURL
- AgainstInValidEmailId
- AgainstInValidGuid

### For bool
- AgainstTrue
- AgainstFalse