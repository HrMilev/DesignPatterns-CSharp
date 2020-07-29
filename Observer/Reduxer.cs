using System.Collections.Generic;

namespace Observer
{
    public class Reduxer : IReduxer
    {
        private readonly IList<IReducer> observers;
        private (int sum, int subtract) state;

        public Reduxer()
        {
            observers = new List<IReducer>();
        }
        public void AddObserver(IReducer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IReducer observer)
        {
            observers.Remove(observer);
        }

        public void Dispatch(IAction action)
        {
            foreach (var ob in observers)
            {
                state = ob.Update(action, state);
            }
        }

        public (int, int) State => (state.sum, state.subtract);
    }
}
