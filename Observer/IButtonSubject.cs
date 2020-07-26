namespace Observer
{
    public interface IButtonSubject
    {
        void AddObserver(IObserver observer);
        void Click();
        void RemoveObserver(IObserver observer);
    }
}