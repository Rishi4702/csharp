namespace NextBiggerTask
{
    public static class NumberExtension
    {
        /// <summary>
        /// Finds the nearest largest integer consisting of the digits of the given positive integer number; return -1 if no such number exists.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>
        /// The nearest largest integer consisting of the digits  of the given positive integer; return -1 if no such number exists.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when source number is less than 0.</exception>
        public static int NextBiggerThan(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("someting");
            }

            int[] counts = new int[10];
            int pre = -1;
            int target = -1;
            long result = 0;

            while (number != 0)
            {
                int cur = number % 10;
                counts[cur]++;
                number /= 10;

                if (cur < pre)
                {
                    target = cur;
                    break;
                }

                pre = cur;
            }

            if (target == -1)
            {
                return -1;
            }

            result = number;

            for (int i = target + 1; i < 10; i++)
            {
                if (counts[i] != 0)
                {
                    counts[i]--;
                    result = (10 * result) + i;
                    break;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                while (counts[i] != 0)
                {
                    result = (10 * result) + i;
                    counts[i]--;
                }
            }

            return result > int.MaxValue ? -1 : (int)result;
        }
    }
}
