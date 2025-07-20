using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLocker.Core.Services
{
    public interface IFileReader
    {
        /// <summary>
        /// Reads the content of a file asynchronously.
        /// </summary>
        /// <param name="filePath">The path of the file to read.</param>
        /// <returns>A task that represents the asynchronous read operation. The task result contains the content of the file as a string.</returns>
        Task<string> ReadFileAsync(string filePath);

        /// <summary>
        /// Reads the bytes of a file asynchronously.
        /// </summary>
        /// <param name="filePath">The path of the file to read.</param>
        /// returns>A task that represents the asynchronous read operation. The task result contains the bytes of the file.</returns>
        Task<byte> ReadFileBytesAsync(string filePath);

        /// <summary>
        /// Reads all lines from a file asynchronously.
        /// </summary>
        /// <param name="filePath">The path of the file to read.</param>
        /// <returns>A task that represents the asynchronous read operation. The task result contains an array of strings, each representing a line in the file.</returns>
        Task<string[]> ReadAllLinesAsync(string filePath);
    }
}
