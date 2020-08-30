using System;

namespace Guard_Pattern
{
    public class Guard : IGuardClause
    {
        public static IGuardClause Against { get; } = new Guard();
    }
}
