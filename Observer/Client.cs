using System;

namespace Observer
{
    public class Client
    {
        //In cases when event happens and it is needed some external
        //notifications to be done (DB, Network etc.), Observer can help
        public static void Main()
        {
            IButtonSubject buttonSubject = new ButtonSubject();
            IObserver observer = new Observer("DbConnector");
            IObserver observer2 = new Observer("NetworkConnector");

            buttonSubject.AddObserver(observer);
            buttonSubject.AddObserver(observer2);

            buttonSubject.Click();
        }
    }
}
