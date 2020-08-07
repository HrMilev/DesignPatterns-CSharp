using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class TypeOneAVisitor : IStructureVisitor
    {
        public void Visit(IStructure structure)
        {
            if (structure is AStructure)
            {
                Console.WriteLine(" - - was visit by Type One \"A\" Visitor");
            }
        }
    }
}
