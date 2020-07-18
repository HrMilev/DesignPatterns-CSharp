using System;
using System.Linq;

class Expression
{
    private delegate double Operation(double a, double b);

    private double Add(double a, double b)
    {
        return a + b;
    }

    private double Subtraction(double a, double b)
    {
        return a - b;
    }

    private Operation Decision(char c)
    {
        if (c == '+')
        {
            return Add;
        }
        else if (c == '-')
        {
            return Subtraction;
        }
        else
        {
            throw new Exception();
        }
    }

    public void Interpret(Content content)
    {
        content.Output += content.Input.First() - '0';
        content.Input = content.Input.Substring(1);
        while (content.Input != "")
        {
            Operation currOperation = Decision(content.Input.First());
            content.Input = content.Input.Substring(1);
            double currentNumber = content.Input.First() - '0';
            content.Input = content.Input.Substring(1);
            content.Output = currOperation(content.Output, currentNumber);
        }
    }
}

