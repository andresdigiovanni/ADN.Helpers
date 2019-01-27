using System;
using System.Collections.Generic;
using System.Linq;

namespace ADN.Helpers.Data
{
    /// <summary>
    /// A static class of extension methods for <see cref="List{T}"/>.
    /// </summary>
    [Obsolete("Class moved to ADN.Extensions", true)]
    public static class ListHelper
    {
        /// <summary>
        /// Find the index of the maximum value of the list.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the list.</typeparam>
        /// <param name="values">The list of elements.</param>
        /// <returns>Index of the maximum value of the list.</returns>
        /// <exception cref="ArgumentNullException">List is null or empty.</exception>
        /// <example>
        /// <code lang="csharp">
        /// var values = new double[] { 10, 11, 12, 13, 12, 11, 10 };
        /// var result = values.IndexOfMax();
        /// 
        /// /*
        /// result is 3
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static int IndexOfMax<T>(this IList<T> values) where T : IComparable
        {
            // Check arguments
            if (values is null || values.Count <= 0)
            {
                throw (new ArgumentNullException("values"));
            }

            int maxIndex = -1;
            T maxValue = values[0];

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].CompareTo(maxValue) >= 0)
                {
                    maxIndex = i;
                    maxValue = values[i];
                }
            }

            return maxIndex;
        }

        /// <summary>
        /// Find the index of the minimum value of the list.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the list.</typeparam>
        /// <param name="values">The list of elements.</param>
        /// <returns>Index of the minimum value of the list.</returns>
        /// <exception cref="ArgumentNullException">List is null or empty.</exception>
        /// <example>
        /// <code lang="csharp">
        /// var values = new double[] { 13, 12, 11, 10, 11, 12, 13 };
        /// var result = values.IndexOfMin();
        /// 
        /// /*
        /// result is 3
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static int IndexOfMin<T>(this IList<T> values) where T : IComparable
        {
            // Check arguments
            if (values is null || values.Count <= 0)
            {
                throw (new ArgumentNullException("values"));
            }

            int minIndex = -1;
            T minValue = values[0];

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].CompareTo(minValue) <= 0)
                {
                    minIndex = i;
                    minValue = values[i];
                }
            }

            return minIndex;
        }

        /// <summary>
        /// Determine if two sequences contains exactly the same elements.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the list.</typeparam>
        /// <param name="first">The first list of elements.</param>
        /// <param name="second">The second list of elements.</param>
        /// <returns>True if two sequences contains exactly the same elements, false otherwise.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var first = new double[] { 0, 1 };
        /// var second = new double[] { 1, 0 };
        /// var result = first.IsSame(second);
        /// 
        /// /*
        /// result is true
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static bool IsSame<T>(this IList<T> first, IList<T> second)
        {
            return new HashSet<T>(first).SetEquals(second); ;
        }

        /// <summary>
        /// Shuffle the elements of the list.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the list.</typeparam>
        /// <param name="values">The list of elements.</param>
        /// <exception cref="ArgumentNullException">List is null or empty.</exception>
        /// <example>
        /// <code lang="csharp">
        /// var values = new double[] { 0, 1, 2, 3, 4, 5 };
        /// values.Shuffle();
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static void Shuffle<T>(this IList<T> values)
        {
            // Check arguments
            if (values is null || values.Count <= 0)
            {
                throw (new ArgumentNullException("values"));
            }

            Random rng = new Random();
            int n = values.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = values[k];
                values[k] = values[n];
                values[n] = value;
            }
        }

        /// <summary>
        /// Gets the value of the middle element of the list after sorted.
        /// </summary>
        /// <param name="values">The list of elements.</param>
        /// <returns>Index of the middle element.</returns>
        /// <exception cref="ArgumentNullException">List is null or empty.</exception>
        /// <example>
        /// <code lang="csharp">
        /// var values = new double[] { 2, 3, 5, 1, 4 };
        /// var result = values.Median();
        /// 
        /// /*
        /// result is 3
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static double Median(this IEnumerable<double> values)
        {
            // Check arguments
            if (values is null || values.Count() <= 0)
            {
                throw (new ArgumentNullException("values"));
            }

            int midIndex = values.Count() / 2;
            var sorted = values.OrderBy(x => x).ToList();

            double median =
                values.Count() % 2 == 0
                    ? (sorted[midIndex] + sorted[midIndex - 1]) / 2
                    : sorted[midIndex];

            return median;
        }

        /// <summary>
        /// Gets the mean of the values of the list.
        /// </summary>
        /// <param name="values">The list of elements.</param>
        /// <returns>Mean of the values.</returns>
        /// <exception cref="ArgumentNullException">List is null or empty.</exception>
        /// <example>
        /// <code lang="csharp">
        /// var values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        /// var result = values.Mean();
        /// 
        /// /*
        /// result is 4.5
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static double Mean(this List<double> values)
        {
            // Check arguments
            if (values is null || values.Count <= 0)
            {
                throw (new ArgumentNullException("values"));
            }

            return values.Count == 0 ? 0 : values.Mean(0, values.Count - 1);
        }

        /// <summary>
        /// Gets the mean of the values of the list of a given range.
        /// </summary>
        /// <param name="values">The list of elements.</param>
        /// <param name="start">Start index.</param>
        /// <param name="end">End index.</param>
        /// <returns>Mean of the values.</returns>
        /// <exception cref="ArgumentNullException">List is null or empty.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Start or end out of range.</exception>
        /// <example>
        /// <code lang="csharp">
        /// int start = 0;
        /// int end = 5;
        /// var values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        /// var result = values.Mean(start, end);
        /// 
        /// /*
        /// result is 2.5
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static double Mean(this List<double> values, int start, int end)
        {
            // Check arguments
            if (values is null || values.Count <= 0)
            {
                throw (new ArgumentNullException("values"));
            }

            if (start < 0 || start >= values.Count)
            {
                throw (new ArgumentOutOfRangeException("start"));
            }

            if (end < 0 || end >= values.Count)
            {
                throw (new ArgumentOutOfRangeException("end"));
            }

            if (start > end)
            {
                throw (new ArgumentOutOfRangeException("end"));
            }

            double s = 0;

            for (int i = start; i <= end; i++)
            {
                s += values[i];
            }

            return s / (end - start + 1);
        }

        /// <summary>
        /// Calculate the variance of the values of the list.
        /// </summary>
        /// <param name="values">The list of elements.</param>
        /// <returns>Variance of values.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        /// var result = values.Variance();
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static double Variance(this List<double> values)
        {
            return values.Variance(values.Mean(), 0, values.Count);
        }

        /// <summary>
        /// Calculate the variance of the values of the list.
        /// </summary>
        /// <param name="values">The list of elements.</param>
        /// <param name="mean">The mean of the values of the list.</param>
        /// <returns>Variance of values.</returns>
        /// <example>
        /// <code lang="csharp">
        /// double mean = 2.5;
        /// var values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        /// var result = values.Variance(mean);
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static double Variance(this List<double> values, double mean)
        {
            return values.Variance(mean, 0, values.Count);
        }

        /// <summary>
        /// Calculate the variance of the values of the list of a given range.
        /// </summary>
        /// <param name="values">The list of elements.</param>
        /// <param name="mean">The mean of the values of the list.</param>
        /// <param name="start">Start index.</param>
        /// <param name="end">End index.</param>
        /// <returns>Variance of values.</returns>
        /// <example>
        /// <code lang="csharp">
        /// int start = 0;
        /// int end = 5;
        /// double mean = 2.5;
        /// var values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        /// var result = values.Variance(mean, start, end);
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static double Variance(this List<double> values, double mean, int start, int end)
        {
            double variance = 0;

            for (int i = start; i < end; i++)
            {
                variance += Math.Pow((values[i] - mean), 2);
            }

            int n = end - start;
            if (start > 0) n--;

            return variance / n;
        }

        /// <summary>
        /// Calculate the standard deviation of the values of the list.
        /// </summary>
        /// <param name="values">The list of elements.</param>
        /// <returns>Standard deviation.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        /// var result = values.StandardDeviation();
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static double StandardDeviation(this List<double> values)
        {
            return values.Count == 0 ? 0 : values.StandardDeviation(0, values.Count);
        }

        /// <summary>
        /// Calculate the standard deviation of the values of the list of a given range.
        /// </summary>
        /// <param name="values">The list of elements.</param>
        /// <param name="start">Start index.</param>
        /// <param name="end">End index.</param>
        /// <returns>Standard deviation.</returns>
        /// <example>
        /// <code lang="csharp">
        /// int start = 0;
        /// int end = 5;
        /// var values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        /// var result = values.StandardDeviation(start, end);
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static double StandardDeviation(this List<double> values, int start, int end)
        {
            double mean = values.Mean(start, end);
            double variance = values.Variance(mean, start, end);

            return Math.Sqrt(variance);
        }
    }
}
