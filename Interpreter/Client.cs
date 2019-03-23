using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        string input = "5+4-3";
        Content content = new Content(input);

        Expression expression = new Expression();

        expression.Interpret(content);

        Console.WriteLine(content.Output);

    }
}

