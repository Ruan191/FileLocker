using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLocker.Core.Models
{
    public class FolderItem
    {
        public required string Name { get; set; }
        public bool IsVisibilityLocked { get; set; }
        public bool IsEncrypted { get; set; }
    }
}
