using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLocker.Core.Services
{
    public interface IFileWriter
    {
        /// <summary>
        /// Writes content to a file asynchronously.
        /// </summary>
        /// <param name="filePath">The path of the file to write to.</param>
        /// <param name="content">The content to write to the file.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        Task WriteFileAsync(string filePath, string content);
        /// <summary>
        /// Writes bytes to a file asynchronously.
        /// </summary>
        /// <param name="filePath">The path of the file to write to.</param>
        /// <param name="bytes">The bytes to write to the file.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        Task WriteFileBytesAsync(string filePath, byte[] bytes);
    }
}
