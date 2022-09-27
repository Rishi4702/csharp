#pragma warning disable S2368

namespace LookingForArrayElements
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i] is null)
                {
                    throw new ArgumentNullException(nameof(ranges), "Method throws ArgumentNullException in case one of the ranges is null");
                }
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i].Length != 2 && ranges[i].Length != 0)
                {
                    throw new ArgumentException("Method throws ArgumentException in case the length of one of the ranges is less or greater than 2");
                }
            }

            if (ranges.Length == 0 || arrayToSearch.Length == 0)
            {
                return 0;
            }

            int counter = 0;
            int index = 0;
            int rangeCount = ranges.Length - 1;

            do
            {
                do
                {
                    if (ranges[rangeCount].Length != 0 &&
                        arrayToSearch[index] >= ranges[rangeCount][0] &&
                        arrayToSearch[index] <= ranges[rangeCount][1])
                    {
                        counter++;
                        break;
                    }
                }
                while (--rangeCount >= 0);

                rangeCount = ranges.Length - 1;
            }
            while (index++ < arrayToSearch.Length - 1);

            return counter;
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[] arrayToSearch, decimal[][] ranges, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (ranges is null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i] is null)
                {
                    throw new ArgumentNullException(nameof(ranges), "Method throws ArgumentNullException in case one of the ranges is null");
                }
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Method throws ArgumentOutOfRangeException in case start index is greater than the length of an array to search.");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Method throws ArgumentOutOfRangeException in case count is less than zero.");
            }

            if (arrayToSearch.Length - startIndex < count)
            {
                throw new ArgumentException("Method throws ArgumentOutOfRangeException in case the number of elements to search is greater than the number of elements available in the array starting from the startIndex position.");
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i].Length != 2 && ranges[i].Length != 0)
                {
                    throw new ArgumentException("Method throws ArgumentException in case the length of one of the ranges is less or greater than 2");
                }
            }

            if (count == 0 || ranges.Length == 0)
            {
                return 0;
            }

            int lastIndex = startIndex + count;
            if (lastIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            int counter = 0;

            for (int i = startIndex; i < lastIndex; i++)
            {
                for (int j = 0; j < ranges.Length; j++)
                {
                    if (ranges[j].Length != 0 &&
                        arrayToSearch[i] >= ranges[j][0] &&
                        arrayToSearch[i] <= ranges[j][1])
                    {
                        counter++;
                        break;
                    }
                }
            }

            return counter;
        }
    }
}
