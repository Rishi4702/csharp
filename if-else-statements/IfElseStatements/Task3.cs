namespace IfStatements
{
    public static class Task3
    {
        public static int DoSomething1(bool b, int i)
        {
            if (b)
            {
                if (i <= -6)
                {
                    i -= 10;
                }

                if (i > -6)
                {
                    i += 1;
                }
            }

            if (!b)
            {
                if (i < 8)
                {
                    i -= 1;
                }

                if (i >= 8)
                {
                    i += 10;
                }
            }

            return i;
        }

        public static int DoSomething2(bool b, int i)
        {
            if (b)
            {
                if (i <= -6)
                {
                    i -= 10;
                }
                else
                {
                    i += 1;
                }
            }
            else
            {
                if (i < 8)
                {
                    i -= 1;
                }
                else
                {
                    i += 10;
                }
            }

            return i;
        }
    }
}
