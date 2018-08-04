using System;

namespace ADN.Helpers.Data
{
    public class IntegerHelper
    {
        public static int RoundNumber(double value, int step)
        {
            if (step == 0)
            {
                throw (new DivideByZeroException("step"));
            }

            return Convert.ToInt32(Math.Round(value / step) * step);
        }

        public static int RoundNumber(double value, int step, int min, int max)
        {
            value = RoundNumber(value, step);

            if (value < min) return min;
            if (value > max) return max;
            return Convert.ToInt32(value);
        }
    }
}
