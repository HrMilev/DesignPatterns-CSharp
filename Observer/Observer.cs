using System;
namespace Observer
{
    public class Observer : IObserver
    {
        public Observer(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Update(EventArg eventArg)
        {
            Console.WriteLine($"{Name} was updated with massage: " + eventArg.Message);
        }
    }
}
