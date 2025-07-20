using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLocker.Core.Services
{
    public interface IFileDiscovery
    {
        /// <summary>
        /// Discovers files in the specified directory.
        /// </summary>
        /// <param name="directoryPath">The path of the directory to search.</param>
        /// <returns>A list of file paths found in the directory.</returns>
        Task<IEnumerable<string>> DiscoverFilesAsync(string directoryPath);
        /// <summary>
        /// Discovers files with a specific extension in the specified directory.
        /// </summary>
        /// <param name="directoryPath">The path of the directory to search.</param>
        /// <param name="fileExtension">The file extension to filter by (e.g., ".txt").</param>
        /// <returns>A list of file paths with the specified extension found in the directory.</returns>
        Task<IEnumerable<string>> DiscoverFilesByExtensionAsync(string directoryPath, string fileExtension);
        /// <summary>
        /// Searches for a file by name in the specified directory.
        /// </summary>
        /// <param name="directoryPath">The path of the directory to search</param>
        /// <returns>A list of file paths that match the specified file name.</returns>
        Task<IEnumerable<string>> FindFileByNameAsync(string directoryPath, string fileName);
    }
}
