using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace ADN.Helpers.Tests
{
    public class ReflectiveSubclassEnumeratorTest
    {
        [Fact]
        public void GetEnumerableOfType()
        {
            var result = ReflectiveSubclassEnumerator.GetEnumerableOfType<AbsFoo>(null).ToList().Count;

            Assert.Equal(2, result);
        }

        public class AbsFoo {}
        public class Foo1 : AbsFoo { }
        public class Foo2 : AbsFoo { }
    }
}
