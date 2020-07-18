using System;
using System.Collections.Generic;

public class House
{
    List<string> parts = new List<string>();
    public void Add(string part)
    {
        this.parts.Add(part);
    }
    public void Show()
    {
        foreach (var part in this.parts)
        {
            Console.WriteLine(part);
        }
        Console.WriteLine();
    }
}
