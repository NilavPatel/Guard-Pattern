using Guard_Clauses;
using System;

namespace Guard_Pattern.Test
{
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
}
