public class CakeList<T> : ICakeList<T>
{
    private T[] menu;

    public CakeList(int count)
    {
        menu = new T[count];
    }

    public int Count
    {
        get { return menu.Count(); }
    }

    public T this[int index]
    {
        get{ return menu[index]; }
        set { menu[index] = value; }
    }

    public IIterator<T> GetIterator()
    {
        return new Iterator<T>(this);
    }
}
