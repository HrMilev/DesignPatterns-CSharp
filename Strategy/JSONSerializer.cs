using System.Text.Json;

namespace Strategy
{
    //This is one of the different parts of the common algorithm
    public class JSONSerializer : ISerializerStrategy
    {
        public string Serialize<T>(T data)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            return JsonSerializer.Serialize(data, options);
        }
    }
}
