﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Helpers.Data
{
    /// <summary>
    /// A static class of extension methods for <see cref="Byte"/> <see cref="Array"/>.
    /// </summary>
    [Obsolete("Class moved to ADN.Extensions", true)]
    public static class ByteHelper
    {
        /// <summary>
        /// Converts the numeric value of a byte array to its equivalent hexadecimal string.
        /// </summary>
        /// <param name="bytes">The value.</param>
        /// <param name="separator">Hexadecimal values separator.</param>
        /// <returns>Hexadecimal string.</returns>
        /// <exception cref="ArgumentNullException">bytes is null</exception>
        /// <example>
        /// <code lang="csharp">
        /// var array = new byte[] { 48, 49, 50, 51, 52 };
        /// var separator = "-";
        /// var result = array.BytesToHexa(separator);
        /// 
        /// /*
        /// result is "30-31-32-33-34"
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static string BytesToHexa(this byte[] bytes, string separator = "")
        {
            // Check arguments
            if (bytes is null)
            {
                throw (new ArgumentNullException("bytes"));
            }

            string sHexa = "";

            for (var i = 0; i < bytes.Length; i++)
            {
                if (!string.IsNullOrEmpty(sHexa))
                {
                    sHexa += separator;
                }
                sHexa += bytes[i].ToString("X").PadLeft(2, '0');
            }

            return sHexa;
        }

        /// <summary>
        /// Converts the hexadecimal string to its quivalent numeric value byte array.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="separator">Hexadecimal values separator.</param>
        /// <returns>Byte array.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var value = "30-31-32-33-34";
        /// var separator = "-";
        /// var result = value.HexaToBytes(separator);
        /// 
        /// /*
        /// result contains the values { 48, 49, 50, 51, 52 }
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static byte[] HexaToBytes(this string value, string separator = "")
        {
            List<byte> bytes = new List<byte>();
            if (separator != "")
            {
                value = value.Replace(separator, "");
            }

            for (int i = 0; i < value.Length; i += 2)
            {
                bytes.Add(Convert.ToByte(value.Substring(i, 2), 16));
            }

            return bytes.ToArray();
        }

        /// <summary>
        /// Decodes a sequence of bytes from the specified byte array into a string.
        /// </summary>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
        /// <remarks>Equivalent to System.Text.Encoding.UTF8.GetString().</remarks>
        /// <example>
        /// <code lang="csharp">
        /// var array = new byte[] { 48, 49, 50, 51, 52 };
        /// var result = array.BytesToString();
        /// 
        /// /*
        /// result is "01234"
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static string BytesToString(this byte[] bytes)
        {
            return Encoding.UTF8.GetString(bytes);
        }

        /// <summary>
        /// Encodes a set of characters into a sequence of bytes.
        /// </summary>
        /// <param name="value">The character array containing the characters to encode.</param>
        /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
        /// <remarks>Equivalent to System.Text.Encoding.UTF8.GetBytes().</remarks>
        /// <example>
        /// <code lang="csharp">
        /// var value = "01234";
        /// var result = value.StringToBytes();
        /// 
        /// /*
        /// result contains the values { 48, 49, 50, 51, 52 }
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.Extensions", true)]
        public static byte[] StringToBytes(this string value)
        {
            return Encoding.UTF8.GetBytes(value);
        }
    }
}
