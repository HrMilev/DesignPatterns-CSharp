using System;

namespace ChainOfResposibility
{
    public class Client
    {
        public static void Main()
        {
            var request = new Request { Body = "No body" };
            var firstPipe = new FirstPipe();
            var secondPipe = new SecondPipe();
            firstPipe.SetNext(secondPipe);

            firstPipe.ProcessRequest(request);

            Console.WriteLine(request.Body);
        }
    }
}
