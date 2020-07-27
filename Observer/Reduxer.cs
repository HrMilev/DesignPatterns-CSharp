using System.Collections.Generic;

namespace Observer
{
    public class Reduxer : IReduxer
    {
        private readonly IList<IReducer> _observers;
        private (int sum, int subtract) state;

        public Reduxer()
        {
            _observers = new List<IReducer>();
        }
        public void AddObserver(IReducer observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IReducer observer)
        {
            _observers.Remove(observer);
        }

        public void Dispatch(IAction action)
        {
            foreach (var ob in _observers)
            {
                state = ob.Update(action, state);
            }
        }

        public (int, int) State => (state.sum, state.subtract);
    }
}
