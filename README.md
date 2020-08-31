# C# Guard Pattern

## This project contains guard clauses for object, string, int, double, decimal, datetime, timespan, URL.

### Examples

````javascript
Guard.Against.Null(name, "Name");
Guard.Against.NullOrEmpty(name, "Name");
Guard.Against.MinimumLength(name, "Name", 10);
Guard.Against.NumberLessThan(money, "Money", 1000);
Guard.Against.NumberGreaterThanOrEqual(money, "Money", 1000);
Guard.Against.NumberNegative(money, "Money");
Guard.Against.DateTimeGreaterThan(startDate, "StartDate", DateTime.Now);
Guard.Against.InValidURL("https://nilavpatel.github.io", "URL");
````

### For generic &lt;T&gt; type
- Null

### For String
- NullOrEmpty
- NullOrWhiteSpace
- LeadingAndTailingSpace
- MinimumLength
- MaximumLength
- SpecialCharacters
- Digits
- Alphabet
- LowerCase
- UpperCase
- Space

### For int, double, decimal
- NumberLessThan
- NumberGreaterThan
- NumberLessThanOrEqual
- NumberGreaterThanOrEqual
- NumberZero
- NumberNegative
- NumberNegativeOrZero
- NumberOutOfRange

### For DateTime
- DateTimeLessThan
- DateTimeGreaterThan
- DateTimeLessThanOrEqual
- DateTimeGreaterThanOrEqual
- DateTimeOutOfRange

### For TimeSpan
- TimeSpanLessThan
- TimeSpanGreaterThan
- TimeSpanLessThanOrEqual
- TimeSpanGreaterThanOrEqual
- TimeSpanOutOfRange

### For Others
- InValidURL
- InValidEmailId
- InValidGuid

### For bool
- True
- False

### How to create custom guard clause?
````javascript
public static class CustomGuardClause
{
    public static void MoreThanMaxLimit(this IGuardClause guardClause, int argument, string argumentName)
    {
        if (argument > Int16.MaxValue)
        {
            throw new ArgumentException(string.Format("Argument {0} is not allowing to be more than Int16 max limit", argumentName));
        }
    }
}
````
