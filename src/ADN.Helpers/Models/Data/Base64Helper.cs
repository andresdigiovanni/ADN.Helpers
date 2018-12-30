using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Helpers.Data
{
    /// <summary>
    /// A static class of methods for Base64 strings.
    /// </summary>
    public static class Base64Helper
    {
        /// <summary>
        /// Converts the value of a plain text string to its equivalent string representation that is encoded with base-64 digits.
        /// </summary>
        /// <param name="plainText">Plain text string.</param>
        /// <returns>String encoded with base-64 digits.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var value = "0123456789";
        /// var result = Base64Helper.Encode(value);
        /// 
        /// /*
        /// result is "MDEyMzQ1Njc4OQ=="
        /// */
        /// </code>
        /// </example>
        public static string Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Converts the specified string, which encodes binary data as base-64 digits, to an equivalent plain text string.
        /// </summary>
        /// <param name="base64EncodedData">String encoded with base-64 digits.</param>
        /// <returns>Plain text string.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var value = "MDEyMzQ1Njc4OQ==";
        /// var result = Base64Helper.Decode(value);
        /// 
        /// /*
        /// result is "0123456789"
        /// */
        /// </code>
        /// </example>
        public static string Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
