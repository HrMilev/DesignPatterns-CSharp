namespace Iterator
{
    public interface IIterator<T>
    {
        bool HasNext { get; }
        T Current();
    }
}
