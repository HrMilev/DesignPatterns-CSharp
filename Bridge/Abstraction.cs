using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Abstraction
{
    IBridge bridge;

    public Abstraction(IBridge implement)
    {
        bridge = implement ;
    }

    public string Operation()
    {
        return bridge.Operation();
    }

}
