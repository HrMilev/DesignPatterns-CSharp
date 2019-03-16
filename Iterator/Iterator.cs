public class Iterator<T> : IIterator<T>
{
    CakeList<T> list;
    int counter;
    public Iterator(CakeList<T> list)
    {
        this.list = list;
    }

    public T Current()
    {
        return list[counter];
    }

    public bool IstFinished()
    {
        return counter < list.Count;
    }

    public T Next()
    {
        return list[counter++];
    }
}
