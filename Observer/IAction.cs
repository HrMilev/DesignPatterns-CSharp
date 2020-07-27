namespace Observer
{
    public interface IAction
    {
        public ActionEnum Action { get; }
        public int PayLoad { get; }
    }
}