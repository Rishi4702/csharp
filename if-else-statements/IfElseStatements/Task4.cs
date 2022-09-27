namespace IfStatements
{
    public static class Task4
    {
        public static int DoSomething(bool b1, bool b2, bool b3, bool b4)
        {
            if (b4)
            {
                if (b3)
                {
                    if (b2)
                    {
                        if (b1)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                    else
                    {
                        if (b1)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
                else
                {
                    if (b2)
                    {
                        if (b1)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                    else
                    {
                        if (b1)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
            else
            {
                if (b3)
                {
                    if (b2)
                    {
                        if (b1)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                    else
                    {
                        if (b1)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
                else
                {
                    if (b1)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
