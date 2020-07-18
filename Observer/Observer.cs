using System;

public class Observer : IObserver
{
    private string name;

    public Observer(string name)
    {
        this.name = name;
    }

    public void ReceivePost(string name, string text)
    {
        Console.WriteLine($"{this.name} recieve post from {name}: \n {text}");
    }
}
