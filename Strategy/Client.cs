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

            //This is the class which we can modify run time 
            var objectToStringMaker = new ObjectToStringMaker('*');
            Console.WriteLine("1 - XML, 2 - JSON :");
            StrategyType strategyType = (StrategyType)int.Parse(Console.ReadLine());
            Console.WriteLine(objectToStringMaker.GetString(data, strategyType));
        }
    }
}
