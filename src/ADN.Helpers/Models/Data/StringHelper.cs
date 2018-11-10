using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Helpers.Data
{
    /// <summary>
    /// A static class of extension methods for <see cref="string"/>.
    /// </summary>
    public static class StringHelper
    {
        /// <summary>
        /// Returns a string containing a specified number of characters from the left side of a string.
        /// </summary>
        /// <param name="str">String expression from which the leftmost characters are returned.</param>
        /// <param name="length">Numeric expression indicating how many characters to return.</param>
        /// <returns>Returns a string containing a specified number of characters from the left side of a string.</returns>
        public static string Left(string str, int length)
        {
            return (str.Length <= length) ? str : str.Substring(0, length);
        }

        /// <summary>
        /// Returns a string that contains a specified number of characters starting from a specified position in a string.
        /// </summary>
        /// <param name="str">String expression from which characters are returned.</param>
        /// <param name="startIndex">Starting position of the characters to return.</param>
        /// <param name="length">Number of characters to return.</param>
        /// <returns>A string that consists of the specified number of characters starting from the specified position in the string.</returns>
        public static string Mid(string str, int startIndex, int length)
        {
            if (str.Length < startIndex) return "";

            return (str.Length < startIndex + length) ? str.Substring(startIndex, str.Length - startIndex)
                                                      : str.Substring(startIndex, length);
        }

        /// <summary>
        /// Returns a string containing a specified number of characters from the right side of a string.
        /// </summary>
        /// <param name="str">String expression from which the rightmost characters are returned.</param>
        /// <param name="length">Numeric expression indicating how many characters to return.</param>
        /// <returns>Returns a string containing a specified number of characters from the right side of a string.</returns>
        public static string Right(string str, int length)
        {
            return (str.Length <= length) ? str : str.Substring(str.Length - length, length);
        }
    }
}
