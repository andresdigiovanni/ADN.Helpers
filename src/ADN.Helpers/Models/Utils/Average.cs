using System;

namespace ADN.Helpers.Utils
{
    /// <summary>
    /// A static class to calculate averages.
    /// </summary>
    /// <example>
    /// <code lang="csharp">
    /// double avg = 0;
    /// int count = 0;
    /// double value;
    /// 
    /// // insert first element
    /// count++;
    /// value = 1;
    /// 
    /// avg = Average.RunningAverage(avg, count, value);
    /// /*
    /// avg is 1
    /// */
    /// 
    /// // insert second element
    /// count++;
    /// value = 3;
    /// 
    /// avg = Average.RunningAverage(avg, count, value);
    /// /*
    /// avg is 2
    /// */
    /// </code>
    /// </example>
    public static class Average
    {
        /// <summary>
        /// Calculate average.
        /// </summary>
        /// <param name="previousAvg">Previous average.</param>
        /// <param name="count">Number of elements with the new value.</param>
        /// <param name="currentValue">New value.</param>
        /// <returns>Average.</returns>
        /// <exception cref="DivideByZeroException">Number of elements is zero.</exception>
        public static double RunningAverage(double previousAvg, int count, double currentValue)
        {
            if (count == 0)
            {
                throw (new DivideByZeroException("count"));
            }

            return (previousAvg * (count - 1) + currentValue) / count;
        }
    }
}
