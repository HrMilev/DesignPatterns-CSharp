namespace Observer
{
    public class MyAction : IAction
    {
        public MyAction(ActionEnum action, int payLoad)
        {
            Action = action;
            PayLoad = payLoad;
        }

        public ActionEnum Action { get; }

        public int PayLoad { get; }
    }
}
