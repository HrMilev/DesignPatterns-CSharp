using System.Collections.Generic;

namespace Observer
{
    public class ButtonSubject : IButtonSubject
    {
        private readonly IList<IObserver> _observers;

        public ButtonSubject()
        {
            _observers = new List<IObserver>();
        }
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Click()
        {
            Notify(new EventArg("Button was clicked"));
        }

        private void Notify(EventArg eventArg)
        {
            foreach (var ob in _observers)
            {
                ob.Update(eventArg);
            }
        }
    }
}
