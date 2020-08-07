using System;

namespace Visitor
{
    public class TypeTwoBVisitor : IStructureVisitor
    {
        public void Visit(IStructure structure)
        {
            if (structure is BStructure)
            {
                Console.WriteLine(" - - was visit by Type Two \"B\" Visitor");
            }
        }
    }
}
