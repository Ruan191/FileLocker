using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLocker.Core.Services
{
    public interface ICryptography
    {
        public string Encrypt(string plainText, string key);
        public string Decrypt(string cipherText, string key);
    }
}
