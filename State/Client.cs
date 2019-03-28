using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        List<IHeating> possibleStates = new List<IHeating> { new Normal(), new Hot(), new Boil() };
        var water = new Water(possibleStates);
        water.AddTemp(55);
        water.CurrentState();
        water.AddTemp(3);
        water.CurrentState();
        water.AddTemp(40);
        water.CurrentState();
        water.AddTemp(40);
        water.CurrentState();

    }
}
