using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        var baker = new Baker();

        for (int i = 0; i < 15; i++)
        {
            ICake cake = baker.MakeCakeFactoryMethod(i);
            cake.Type();
        }
    }
}
