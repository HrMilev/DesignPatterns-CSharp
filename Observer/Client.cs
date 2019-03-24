using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        Blogger blogger = new Blogger("Georgio");
        Observer observerF = new Observer("Peter");
        Observer observerS = new Observer("Jilia");
        Observer observerT = new Observer("Helen");

        blogger.Subscribe(observerF);
        blogger.Subscribe(observerS);
        blogger.Subscribe(observerT);
        blogger.MakePost("I was in the kitchen today, it was fun.");
        Console.WriteLine();
        blogger.Unsubscribe(observerT);
        blogger.MakePost("I have a nice day in the living room.");
    }
}
