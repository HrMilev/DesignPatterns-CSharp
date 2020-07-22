using System.IO;
using System.Xml.Serialization;

namespace Strategy
{
    public class XMLSerializer : ISerializerStrategy
    {
        public string Serialize<T>(T data)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using StringWriter textWriter = new StringWriter();
            xmlSerializer.Serialize(textWriter, data);
            return textWriter.ToString();
        }
    }
}
