using ADN.Helpers.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ADN.Helpers.Tests.IO
{
    public class FileHelperTest
    {
        [Fact]
        public void IsFileOpen_True()
        {
            string fileName = "foo";
            FileStream fileStream = File.Create(fileName);

            Assert.True(FileHelper.IsFileOpen(fileName));
        }

        [Fact]
        public void IsFileOpen_False()
        {
            string fileName = "foo";
            FileStream fileStream = File.Create(fileName);
            fileStream.Close();

            Assert.False(FileHelper.IsFileOpen(fileName));
        }
    }
}
