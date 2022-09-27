namespace WhileStatements
{
    public static class QuadraticSequences
    {
        public static long SumQuadraticSequenceTerms1(long a, long b, long c, long maxTerm)
        {
            int i = 1;
            long sum = 0, term = 0;

            while (term <= maxTerm)
            {
                term = (a * i * i) + (b * i) + c;
                if (term <= maxTerm)
                {
                    sum += term;
                }

                i++;
            }

            return sum;
        }

        public static long SumQuadraticSequenceTerms2(long a, long b, long c, long startN, long count)
        {
            int i = 1;
            long term = 0, sum = 0;
            while (count > 0)
            {
                term = (a * i * i) + (b * i) + c;

                if (i >= startN)
                {
                    sum += term;
                    count--;
                }

                i++;
            }

            return sum;
        }
    }
}
