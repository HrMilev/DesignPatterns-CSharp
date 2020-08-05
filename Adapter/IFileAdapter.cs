using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface IFileAdapter
    {
        void WriteToFile(string path, string content);
    }
}
