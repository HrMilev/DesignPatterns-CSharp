using System;
namespace Strategy
{
    public class Client
    {
        static void Main()
        {
            var data = new Data
            {
                Text = "Best example ever",
                Int = 777
            };

            ISerializerStrategy serializerStrategy = new XMLSerializer();
            //This is the class which we can modify run time (although this is the case)
            var objectToStringMaker = new ObjectToStringMaker(serializerStrategy, '*');

            Console.WriteLine(objectToStringMaker.GetString(data));

            objectToStringMaker.Serializer = new JSONSerializer();
            objectToStringMaker.Separator = '#';

            Console.WriteLine(objectToStringMaker.GetString(data));
        }
    }
}
