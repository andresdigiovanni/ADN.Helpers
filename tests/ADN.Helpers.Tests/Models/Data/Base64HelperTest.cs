using ADN.Helpers.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ADN.Helpers.Tests.Data
{
    public class Base64HelperTest
    {
        [Theory]
        [InlineData("0123456789", "MDEyMzQ1Njc4OQ==")]
        [InlineData("This is a test", "VGhpcyBpcyBhIHRlc3Q=")]
        public void Base64Encode(string value, string expected)
        {
            var result = value.Base64Encode();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("MDEyMzQ1Njc4OQ==", "0123456789")]
        [InlineData("VGhpcyBpcyBhIHRlc3Q=", "This is a test")]
        public void Base64Decode(string value, string expected)
        {
            var result = value.Base64Decode();
            Assert.Equal(expected, result);
        }
    }
}
