using System;

namespace ADN.Helpers.Data
{
    /// <summary>
    /// A static class of extension methods for <see cref="int"/>.
    /// </summary>
    public static class IntegerHelper
    {
        /// <summary>
        /// Rounds a value to the nearest integer with the given step.
        /// </summary>
        /// <param name="value">A double-precision floating-point number to be rounded.</param>
        /// <param name="step">Step number to round.</param>
        /// <returns>The number nearest to value that is multiple of the given step.</returns>
        public static int RoundNumber(double value, int step)
        {
            if (step == 0)
            {
                throw (new DivideByZeroException("step"));
            }

            return Convert.ToInt32(Math.Round(value / step) * step);
        }

        /// <summary>
        /// Rounds a value to the nearest integer with the given step and within the determined range.
        /// </summary>
        /// <param name="value">A double-precision floating-point number to be rounded.</param>
        /// <param name="step">Step number to round.</param>
        /// <param name="min">Minimum value.</param>
        /// <param name="max">Maximum value.</param>
        /// <returns>The number nearest to value that is multiple of the given step and within the determined range.</returns>
        public static int RoundNumber(double value, int step, int min, int max)
        {
            value = RoundNumber(value, step);

            if (value < min) return min;
            if (value > max) return max;
            return Convert.ToInt32(value);
        }
    }
}
