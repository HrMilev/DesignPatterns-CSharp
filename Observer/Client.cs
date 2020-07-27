using System;

namespace Observer
{
    public class Client
    {
        //In cases when event happens and it is needed some external
        //notifications to be done (DB, Network etc.), Observer can help
        public static void Main()
        {
            Func<ActionEnum, int, IAction> actionCreator = (a, p) => new MyAction(a, p);

            IReduxer redux = new Reduxer();
            IReducer observer = new Reducer();

            redux.AddObserver(observer);

            redux.Dispatch(actionCreator(ActionEnum.Add, 5));
            redux.Dispatch(actionCreator(ActionEnum.Subtract, 5));

            Console.WriteLine(redux.State);
        }
    }
}
