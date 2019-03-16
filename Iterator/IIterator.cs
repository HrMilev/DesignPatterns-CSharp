public interface IIterator<T>
{
    T Next();
    bool IstFinished();
    T Current();
}
