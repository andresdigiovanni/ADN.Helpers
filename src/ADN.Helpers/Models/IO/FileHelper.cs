using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ADN.Helpers.IO
{
    /// <summary>
    /// A static class of extension methods for <see cref="File"/>.
    /// </summary>
    [Obsolete("Class moved to ADN.IO", true)]
    public class FileHelper
    {
        /// <summary>
        /// Check if a file is open.
        /// </summary>
        /// <param name="file">File name.</param>
        /// <param name="fileAccess">File access.</param>
        /// <returns>True if file is open, false otherwise.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var file= "foo";
        /// var fileAccess = FileAccess.ReadWrite;
        /// var fileIsOpen = FileHelper.IsFileOpen(file, fileAccess)
        /// 
        /// /*
        /// fileIsOpen is true if file is open, false otherwise.
        /// */
        /// </code>
        /// </example>
        [Obsolete("Class moved to ADN.IO", true)]
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
