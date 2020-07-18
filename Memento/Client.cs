using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        TimeMachine machine = new TimeMachine();
        SaverOfTime saverOfTime = new SaverOfTime();
        saverOfTime.Memento = machine.SetMemento();
        machine.GoToTheFuture();
        machine.CurrentTimeIs();
        machine.GetMemento(saverOfTime.Memento);
        machine.CurrentTimeIs();

    }
}
