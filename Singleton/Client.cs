using System;

namespace Singleton
{
    public class Client
    {
        //Singleton should be used for things that can needs to be one and only in the application 
        //And needs to be tested (interface can be easly mocked)
        //s1 and s2 point to the same place in memory
        public static void Main()
        {
            IPureFunctionerSingleton s1 = PureFunctionerSingleton.Instance;
            IPureFunctionerSingleton s2 = PureFunctionerSingleton.Instance;
            Console.WriteLine(s1.Equals(s2));
            MethodToPresentDIPrinciple(s1);
        }

        private static void MethodToPresentDIPrinciple(IPureFunctionerSingleton s1)
        {
            foreach (var i in s1.VectorAddition(new[] { 1m, 2m, 3m, 4m }, new[] { 1m, 2m, 3m, 4m }, new[] { 1m, 2m, 3m, 4m }))
            {
                Console.WriteLine(i);
            }
        }
    }
}
