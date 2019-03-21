using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Multiphone phone = new Multiphone();

        Friend bestFirst = new Friend(phone, "John");
        Friend bestSecond = new Friend(phone, "Jill");
        Friend bestThird = new Friend(phone, "Gillig");

        bestFirst.MakeCall("How are you?");
    }
}
