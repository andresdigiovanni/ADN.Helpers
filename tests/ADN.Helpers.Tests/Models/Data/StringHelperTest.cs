using ADN.Helpers.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ADN.Helpers.Tests.Data
{
    public class StringHelperTest
    {
        [Theory]
        [InlineData("abcdefghij", 0, "")]
        [InlineData("abcdefghij", 5, "abcde")]
        [InlineData("abcdefghij", 10, "abcdefghij")]
        [InlineData("abcdefghij", 15, "abcdefghij")]
        public void Left(string value, int length, string expected)
        {
            var result = value.Left(length);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abcdefghij", 0, 0, "")]
        [InlineData("abcdefghij", 0, 5, "abcde")]
        [InlineData("abcdefghij", 5, 10, "fghij")]
        [InlineData("abcdefghij", 5, 15, "fghij")]
        public void Mid(string value, int startIndex, int length, string expected)
        {
            var result = value.Mid(startIndex, length);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abcdefghij", 0, "")]
        [InlineData("abcdefghij", 5, "fghij")]
        [InlineData("abcdefghij", 10, "abcdefghij")]
        [InlineData("abcdefghij", 15, "abcdefghij")]
        public void Right(string value, int length, string expected)
        {
            var result = value.Right(length);
            Assert.Equal(expected, result);
        }
    }
}
