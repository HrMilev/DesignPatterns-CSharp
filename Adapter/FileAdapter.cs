using System.IO;

namespace Adapter
{
    public class FileAdapter
    {
        public void WriteToFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public string ReadFromFile(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
