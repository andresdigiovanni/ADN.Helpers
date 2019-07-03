using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.Helpers.Tests
{
    public class EnumHelperTest
    {
        public enum Foo
        {
            A = 1,
            B = 2,
            C = 4,
            D = 8
        }

        [Theory]
        [InlineData("A", Foo.A, false)]
        [InlineData("a", Foo.A, true)]
        [InlineData("B", Foo.B, false)]
        [InlineData("b", Foo.B, true)]
        public void GetEnumValue(string value, Foo expected, bool ignoreCase)
        {
            var result = EnumHelper.GetEnumValue(typeof(Foo), value, ignoreCase);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetEnumValue_Exception_Argument()
        {
            Assert.Throws<ArgumentException>(() => EnumHelper.GetEnumValue(Foo.A.GetType(), "Z"));
        }
    }
}
