using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class TypeOneBVisitor : IStructureVisitor
    {
        public void Visit(IStructure structure)
        {
            if (structure is BStructure)
            {
                Console.WriteLine(" - - was visit by Type One \"B\" Visitor");
            }
        }
    }
}
