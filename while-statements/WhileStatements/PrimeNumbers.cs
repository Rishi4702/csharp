namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            if (n <= 1)
            {
                return false;
            }

            int i = 2;
            while (i < n)
            {
                if (n % i == 0)
                {
                    return false;
                }

                i++;
            }

            return true;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            bool isLatest = false;
            uint temp = 2;
            if (n < 2)
            {
                return 0;
            }

            while (!isLatest && n > 2)
            {
                if (IsPrimeNumber(n))
                {
                    isLatest = true;
                    temp = n;
                }

                n--;
            }

            return temp;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            uint sum = 0, a = 0, b = 0;
            while (count > 0 && n > 1)
            {
                a = GetLastPrimeNumber(n);
                if (a != b)
                {
                    sum += a;
                    b = a;
                    count--;
                }

                n--;
            }

            return sum;
        }
    }
}
