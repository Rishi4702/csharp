namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            ulong k;
            ulong sum = 0;
            while (n != 0)
            {
                k = n % 10;
                n /= 10;
                sum += k;
            }

            return sum;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            ulong k;
            ulong mul = 1;
            if (n == 0)
            {
                return 0;
            }

            while (n != 0)
            {
                k = n % 10;
                n /= 10;
                mul *= k;
            }

            return mul;
        }
    }
}
