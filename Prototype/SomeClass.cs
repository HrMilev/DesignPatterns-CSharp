namespace Prototype
{
    public class SomeClass : IPrototype<SomeClass>
    {
        public SomeClass(string prop)
        {
            Prop = prop;
        }

        public string Prop { get; }

        public SomeClass Clone()
        {
            return new SomeClass(this.Prop);
        }
    }
}
