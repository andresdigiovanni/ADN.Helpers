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
        const string SOURCE_DIR = "source";
        const string SOURCE_SUB_DIR = "subDir";
        const string DEST_DIR = "dest";
        const string FILE_NAME = "foo";

        [Fact]
        public void CopyDirectory()
        {
            TearDown();

            //create source files
            Directory.CreateDirectory(SOURCE_DIR);
            Directory.CreateDirectory(Path.Combine(SOURCE_DIR, SOURCE_SUB_DIR));
            using (File.Create(Path.Combine(SOURCE_DIR, SOURCE_SUB_DIR, FILE_NAME))) { }

            DirectoryHelper.CopyDirectory(SOURCE_DIR, DEST_DIR);
            Assert.True(File.Exists(Path.Combine(DEST_DIR, SOURCE_SUB_DIR, FILE_NAME)));
        }

        [Fact]
        public void CopyDirectory_Overwrite()
        {
            TearDown();

            bool overwrite = true;

            //create source files
            Directory.CreateDirectory(SOURCE_DIR);
            Directory.CreateDirectory(DEST_DIR);
            using (File.Create(Path.Combine(SOURCE_DIR, FILE_NAME))) { }
            using (File.Create(Path.Combine(DEST_DIR, FILE_NAME))) { }

            DirectoryHelper.CopyDirectory(SOURCE_DIR, DEST_DIR, overwrite);
            Assert.True(File.Exists(Path.Combine(DEST_DIR, FILE_NAME)));
        }

        [Fact]
        public void CopyDirectory_Exception_SourceNotExists()
        {
            TearDown();

            Assert.Throws<DirectoryNotFoundException>(() => DirectoryHelper.CopyDirectory(SOURCE_DIR, DEST_DIR));
        }

        private void TearDown()
        {
            if (Directory.Exists(SOURCE_DIR))
                Directory.Delete(SOURCE_DIR, true);

            if (Directory.Exists(DEST_DIR))
                Directory.Delete(DEST_DIR, true);
        }
    }
}
