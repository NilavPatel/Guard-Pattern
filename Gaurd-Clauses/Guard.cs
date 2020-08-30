namespace Guard_Clauses
{
    public class Guard : IGuardClause
    {
        private static IGuardClause against;
        public static IGuardClause Against
        {
            get
            {
                if (against == null)
                {
                    against = new Guard();
                }
                return against;
            }
        }

        private Guard()
        { }
    }
}
