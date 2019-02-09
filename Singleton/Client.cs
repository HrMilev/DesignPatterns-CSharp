using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Singleton
{

    class Client
    {
        static void Main(string[] args)
        {
            Singleton first = Singleton.Instance;
            Singleton second = Singleton.Instance;
        }
    }
}
