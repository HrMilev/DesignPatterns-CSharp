namespace Observer
{
    public interface IReducer
    {
        (int, int) Update(IAction action, (int sum, int subtract) state);
    }
}