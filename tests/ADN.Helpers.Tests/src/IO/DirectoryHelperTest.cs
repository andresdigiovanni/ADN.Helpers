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
    public class DirectoryHelperTest
    {
        [Fact]
        public void CopyDirectory()
        {
            string sourceDir = "source";
            string sourceSubDir = "subDir";
            string destDir = "dest";
            string fileName = "foo";

            //create source files
            Directory.CreateDirectory(sourceDir);
            Directory.CreateDirectory(Path.Combine(sourceDir, sourceSubDir));
            FileStream fileStream = File.Create(Path.Combine(sourceDir, sourceSubDir, fileName));
            fileStream.Close();

            DirectoryHelper.CopyDirectory(sourceDir, destDir);
            Assert.True(File.Exists(Path.Combine(destDir, sourceSubDir, fileName)));
        }

        [Fact]
        public void CopyDirectory_Exception_SourceNotExists()
        {
            string sourceDir = "source";
            string destDir = "dest";

            Assert.Throws<DirectoryNotFoundException>(() => DirectoryHelper.CopyDirectory(sourceDir, destDir));
        }
    }
}
