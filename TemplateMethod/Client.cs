using System;
using TemplateMethod;

public class Client
{
    public static void Main()
    {
        //Allows you to put duplicated code into a base class
        //Easy to add new but similar algorithms
        //but
        //users are restricted by the given skeleton
        //don't forget L in SOLID
        ItIsTimeTo(new PoolGoOuter());

        ItIsTimeTo(new DinnerGoOuter());
        
    }

    public static void ItIsTimeTo(GoOuterTemplate goOuter)
    {
        Console.WriteLine(goOuter.LetsGo());
    }
}
