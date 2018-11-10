using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Helpers.Data
{
    /// <summary>
    /// A static class of extension methods for <see cref="DateTime"/>.
    /// </summary>
    public static class DateTimeHelper
    {
        /// <summary>
        /// Converts DateTime to unix time stamp.
        /// </summary>
        /// <param name="date">The DateTime.</param>
        /// <returns>The unix time stamp.</returns>
        public static long DateTimeToUnixTimeStamp(DateTime date)
        {
            long unixTimestamp = date.Ticks - new DateTime(1970, 1, 1).Ticks;
            unixTimestamp /= TimeSpan.TicksPerSecond;

            return unixTimestamp;
        }

        /// <summary>
        /// Converts unix time stamp to DateTime.
        /// </summary>
        /// <param name="unixTimestamp">The unix time stamp.</param>
        /// <returns>The DateTime.</returns>
        public static DateTime UnixTimeStampToDateTime(long unixTimestamp)
        {
            DateTime date = new DateTime(1970, 1, 1);
            long unixTimeStampInTicks = unixTimestamp * TimeSpan.TicksPerSecond;

            return new DateTime(date.Ticks + unixTimeStampInTicks);
        }
    }
}
