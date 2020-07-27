namespace Observer
{
    public interface IReduxer
    {
        (int, int) State { get; }

        void AddObserver(IReducer observer);
        void Dispatch(IAction action);
        void RemoveObserver(IReducer observer);
    }
}