using System.Text;

namespace Strategy
{
    public class ObjectToStringMaker
    {
        //This class can contain its own business logic
        //If we have common logic for few cases and only some part of it is different
        //we can encapsulate it in classes with common interface
        public ObjectToStringMaker(ISerializerStrategy serializerStrategy, char separator)
        {
            Serializer = serializerStrategy;
            Separator = separator;
        }
        //This is the reference to the selected (from outside) algorithm (in this case type of serialization)
        public ISerializerStrategy Serializer { get; set; }
        public char Separator { get; set; }

        public string GetString<T>(T obj)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(WithWhat());
            stringBuilder.AppendLine(Serializer.Serialize(obj));
            stringBuilder.AppendLine(new string(Separator, 40));
            return stringBuilder.ToString();
        }

        private string WithWhat()
        {
            return $"Serialization via {Serializer.GetType().Name}:";
        }
    }
}
