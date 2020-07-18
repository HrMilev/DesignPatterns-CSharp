using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Singleton
{
    public sealed class Singleton
    {
        private static Lazy<Singleton> instance = new Lazy<Singleton>(()=> new Singleton());

        Singleton() { }

        public static Singleton Instance => instance.Value;

    }
}
