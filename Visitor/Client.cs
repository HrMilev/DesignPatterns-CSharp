using System.Collections.Generic;

namespace Visitor
{
    public class Client
    {
        public static void Main()
        {
            IList<IStructure> structures = new List<IStructure>
            {
                new AStructure(),
                new BStructure()
            };

            IStructureVisitor structureVisitor = new GenericTypeVisitor(
                new TypeOneAVisitor(),
                new TypeOneBVisitor(),
                new TypeTwoBVisitor(),
                new TypeTwoAVisitor());

            foreach (var structure in structures)
            {
                structureVisitor.Visit(structure);
            }
        }
    }
}
