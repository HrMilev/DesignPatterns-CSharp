using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Component<T> : IComponent<T>
{
    public T Item { get; set; }

    public Component(T item)
    {
        Item = item;
    }

    public void Add(IComponent<T> c)
    {
        Console.WriteLine("Cannot add an item");
    }

    public string Display(int depth)
    {
        return new String('-', depth) + Item + "\n";
    }

    public IComponent<T> Find(T s)
    {
        if (s.Equals(Item))
        {
            return this;
        }
        else
        {
            return null;
        }
    }

    public IComponent<T> Remove(T s)
    {
        Console.WriteLine("Cannot remove directly");
        return this;
    }


}

