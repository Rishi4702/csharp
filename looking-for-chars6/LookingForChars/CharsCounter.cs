namespace LookingForChars
{
    public static class CharsCounter
    {
        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <returns>The number of occurrences of all characters.</returns>
        public static int GetCharsCount(string str, char[] chars)
        {
            if (chars is null || str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int result = 0;
            for (int i = 0; i <= str.Length - 1; i++)
            {
                for (int j = 0; j <= chars.Length - 1; j++)
                {
                    if (str[i] == chars[j])
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <returns>The number of occurrences of all characters within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex)
        {
            if (chars is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentOutOfRangeException(nameof(str));
            }

            if (startIndex < 0 || endIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(str));
            }

            if (startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(str));
            }

            if (startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(str));
            }

            int result = 0;
            int i = startIndex - 1;
            int j = 0;

            while (i <= endIndex - 1)
            {
                i++;
                while (j <= chars.Length - 1)
                {
                    if (str[i] == chars[j])
                    {
                        result++;
                    }

                    j++;
                }

                j = 0;
            }

            return result;
        }

        /// <summary>
        /// Searches a string for a limited number of characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <param name="limit">A maximum number of characters to search.</param>
        /// <returns>The limited number of occurrences of characters to search for within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex, int limit)
        {
            if (str is null || chars is null)
            {
                throw new System.ArgumentNullException(nameof(str));
            }

            if (startIndex < 0 || endIndex < 0 || startIndex > str.Length || startIndex > endIndex || endIndex > str.Length || limit < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(str));
            }

            int result = 0;
            int i = startIndex;
            int j = 0;

            do
            {
                do
                {
                    if (chars[j] == str[i])
                    {
                        result++;

                        if (result == limit)
                        {
                            return result;
                        }
                    }

                    i++;
                }
                while (i <= endIndex);

                i = startIndex;
                j++;
            }
            while (j <= chars.Length - 1);

            return result;
        }
    }
}
