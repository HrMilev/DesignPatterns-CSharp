using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        Director director = new Director(new DoTheJob());
        director.GoToWork();
    }
}
