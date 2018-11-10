using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ADN.Helpers.IO
{
    /// <summary>
    /// A static class of extension methods for <see cref="File"/>.
    /// </summary>
    public class FileHelper
    {
        /// <summary>
        /// Check if a file is open.
        /// </summary>
        /// <param name="file">File name.</param>
        /// <param name="fileAccess">File access.</param>
        /// <returns>True if file is open, false otherwise.</returns>
        public static bool IsFileOpen(string file, FileAccess fileAccess = FileAccess.ReadWrite)
        {
            try
            {
                FileStream fs = new FileStream(file, FileMode.Open, fileAccess);
                fs.Close();
            }
            catch (IOException)
            {
                return true;
            }

            return false;
        }
    }
}
