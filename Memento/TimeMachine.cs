using System;

[Serializable]
public class TimeMachine
{
    private DateTime time;
    public TimeMachine()
    {
        this.time = DateTime.Now;
        Console.WriteLine("Now time is: " + this.time);
    }

    public void CurrentTimeIs()
    {
        Console.WriteLine("Current time is: " + this.time);
    }

    public void GoToTheFuture()
    {
        this.time += new TimeSpan(11,11,11);
    }

    public Memento SetMemento()
    {
        Memento memento = new Memento();
        return memento.Save(this.time);
    }

    public void GetMemento(Memento memento)
    {
        this.time = (DateTime)memento.Restore();

    }
}
