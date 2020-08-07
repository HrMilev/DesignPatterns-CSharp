using System;

namespace Visitor
{
    public class TypeTwoAVisitor : IStructureVisitor
    {
        public void Visit(IStructure structure)
        {
            if (structure is AStructure)
            {
                Console.WriteLine(" - - was visit by Type Two \"A\" Visitor");
            }
        }
    }
}
