using System;

namespace Guard_Pattern
{
    public class Guard : IGuardClause
    {
        private static IGuardClause _against;
        public static IGuardClause Against
        {
            get
            {
                if (_against == null)
                {
                    _against = new Guard();
                }
                return _against;
            }
        }

        private Guard()
        { }
    }
}
