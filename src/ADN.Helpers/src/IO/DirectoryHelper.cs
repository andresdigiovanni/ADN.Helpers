using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ADN.Helpers.IO
{
    /// <summary>
    /// A static class of extension methods for <see cref="Directory"/>.
    /// </summary>
    public static class DirectoryHelper
    {
        /// <summary>
        /// Copy files from the source folder to destination folder overwriting the content
        /// </summary>
        /// <param name="source">Source folder</param>
        /// <param name="destination">Destination folder</param>
        /// <param name="overwrite">Overwrite destination file</param>
        /// <remarks>
        /// This method check if is posible to override a file and retry it
        /// </remarks>
        public static void CopyDirectory(string source, string destination, bool overwrite = false)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(source);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + source);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destination, file.Name);
                file.CopyTo(temppath, overwrite);
            }

            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destination, subdir.Name);
                CopyDirectory(subdir.FullName, temppath);
            }
        }
    }
}
