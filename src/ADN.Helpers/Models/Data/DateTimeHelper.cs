using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Helpers.Data
{
    /// <summary>
    /// A static class of extension methods for <see cref="DateTime"/>.
    /// </summary>
    [Obsolete("Class moved to ADN.Extensions", true)]
    public static class DateTimeHelper
    {
        /// <summary>
        /// Converts DateTime to unix time stamp.
        /// </summary>
        /// <param name="date">The DateTime.</param>
        /// <returns>The unix time stamp.</returns>
        /// <example>
        /// <code lang="csharp">
        /// DateTime date = DateTime.Parse("02/16/2008 12:15:12", new CultureInfo("en-US"));
        /// var result = date.DateTimeToUnixTimeStamp();
        /// 
        /// /*
        /// result is 1203164112
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static long DateTimeToUnixTimeStamp(this DateTime date)
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
        /// <example>
        /// <code lang="csharp">
        /// long unixTimestamp = 1203164112;
        /// var result = unixTimestamp.UnixTimeStampToDateTime().ToString("MM/dd/yyyy HH:mm:ss");
        /// 
        /// /*
        /// result is 02/16/2008 12:15:12
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static DateTime UnixTimeStampToDateTime(this long unixTimestamp)
        {
            DateTime date = new DateTime(1970, 1, 1);
            long unixTimeStampInTicks = unixTimestamp * TimeSpan.TicksPerSecond;

            return new DateTime(date.Ticks + unixTimeStampInTicks);
        }
    }
}
