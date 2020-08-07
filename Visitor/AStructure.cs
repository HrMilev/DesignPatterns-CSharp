using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class AStructure : IStructure
    {
        public void SomeTypicalMethod()
        {
            Console.WriteLine("Structure type A");
        }
    }
}
