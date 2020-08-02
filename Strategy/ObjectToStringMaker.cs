using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Strategy
{
    public class ObjectToStringMaker
    {
        private Dictionary<StrategyType, Type> strategies;
        //This class can contain its own business logic
        //If we have common logic for few cases and only some part of it is different
        //we can encapsulate it in classes with common interface
        public ObjectToStringMaker(char separator)
        {
            var type = typeof(ISerializerStrategy);
            var types = Assembly.GetExecutingAssembly().GetTypes()
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface);
            strategies = types.ToDictionary(x => (StrategyType)Enum.Parse(typeof(StrategyType), x.Name), y => y);

            Separator = separator;
        }
        //This is the reference to the selected (from outside) algorithm (in this case type of serialization)
        public ISerializerStrategy Serializer { get; set; }
        public char Separator { get; set; }

        public string GetString<T>(T obj, StrategyType strategyType)
        {
            Serializer = (ISerializerStrategy)Activator.CreateInstance(strategies[strategyType]);
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
