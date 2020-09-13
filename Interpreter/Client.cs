using System;

namespace Interpreter
{
    public class Client
    {
        public static void Main()
        {
            string input = "5+4-3";
            Content content = new Content(input);

            Expression expression = new Expression();

            expression.Interpret(content);

            Console.WriteLine(content.Output);
        }
    }
}
