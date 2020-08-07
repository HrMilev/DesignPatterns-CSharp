namespace Visitor
{
    public class GenericTypeVisitor : IStructureVisitor
    {
        private readonly IStructureVisitor[] structureVisitors;

        public GenericTypeVisitor(params IStructureVisitor[] structureVisitors)
        {
            this.structureVisitors = structureVisitors;
        }

        public void Visit(IStructure structure)
        {
            structure.SomeTypicalMethod();
            foreach (var visitor in structureVisitors)
            {
                visitor.Visit(structure);
            }
        }
    }
}
