using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Strategy
{
    [XmlType("data")]
    public class Data
    {
        [XmlElement("some_text")]
        [JsonPropertyName("someText")]
        public string Text { get; set; }
        [XmlElement("int")]
        [JsonPropertyName("int")]
        public int Int { get; set; }
    }
}
