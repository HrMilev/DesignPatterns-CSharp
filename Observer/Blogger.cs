using System.Collections.Generic;

public class Blogger
{
    private delegate void Post(string name, string text);

    private event Post Send;

    private string name;
    private List<IObserver> observers;

    public Blogger(string name)
    {
        this.name = name;
        this.observers = new List<IObserver>();
    }

    public void MakePost(string text)
    {
        Send?.Invoke(name, text);
    }

    public void Subscribe(IObserver observer)
    {
        this.observers.Add(observer);
        this.Send += observer.ReceivePost;
    }

    public void Unsubscribe(IObserver observer)
    {
        if (observers.Contains(observer))
        {
            observers.Remove(observer);
            Send -= observer.ReceivePost;
        }
    }
}
