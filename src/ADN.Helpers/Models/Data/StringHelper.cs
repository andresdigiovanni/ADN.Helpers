using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
        /// <example>
        /// <code lang="csharp">
        /// var value = "abcdefghij";
        /// var length = 5;
        /// var result = value.Left(length);
        /// 
        /// /*
        /// result is "abcde"
        /// */
        /// </code>
        /// </example>
        public static string Left(this string str, int length)
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
        /// <example>
        /// <code lang="csharp">
        /// var value = "abcdefghij";
        /// var startIndex = 3;
        /// var length = 5;
        /// var result = value.Mid(startIndex, length);
        /// 
        /// /*
        /// result is "defgh"
        /// */
        /// </code>
        /// </example>
        public static string Mid(this string str, int startIndex, int length)
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
        /// <example>
        /// <code lang="csharp">
        /// var value = "abcdefghij";
        /// var length = 5;
        /// var result = value.Right(length);
        /// 
        /// /*
        /// result is "fghij"
        /// */
        /// </code>
        /// </example>
        public static string Right(this string str, int length)
        {
            return (str.Length <= length) ? str : str.Substring(str.Length - length, length);
        }

        /// <summary>
        /// Returns a string without the non-printable ASCII characters from a string (characters between space and tilde).
        /// </summary>
        /// <param name="value">String to remove the non-printable ASCII characters.</param>
        /// <returns>A string without the non-printable ASCII characters from a string (characters between space and tilde).</returns>
        /// <example>
        /// <code lang="csharp">
        /// var value = (char)0x12 + " a~";
        /// var result = value.TrimNonPrintableAscii();
        /// 
        /// /*
        /// result is " a~"
        /// */
        /// </code>
        /// </example>
        public static string TrimNonPrintableAscii(this string value)
        {
            string pattern = "[^ -~]+";
            Regex regex = new Regex(pattern);
            return regex.Replace(value, "");
        }
    }
}
