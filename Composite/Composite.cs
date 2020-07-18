using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Composite<T> : IComponent<T>
{
    List<IComponent<T>> list;

    public T Item { get ; set ; }

    public Composite(T item)
    {
        Item = item;
        list = new List<IComponent<T>>();
    }

    public void Add(IComponent<T> c)
    {
        list.Add(c);
    }

    public string Display(int depth)
    {
        StringBuilder s = new StringBuilder(new String('-', depth));
        s.Append("Set " + Item + " length :" + list.Count + "\n");
        foreach (var item in list)
        {
            s.Append(item.Display(depth + 2));
        }
        return s.ToString();
    }

    IComponent<T> holder;

    public IComponent<T> Find(T s)
    {
        holder = this;
        if (Item.Equals(s))
        {
            return this;
        }
        IComponent<T> found = null;
        foreach (var item in list)
        {
            found = item.Find(s);
            if (found!=null)
            {
                break;
            }
        }
        return found;
    }

    public IComponent<T> Remove(T s)
    {
        holder = this;
        IComponent<T> p = holder.Find(s);
        if (holder!=null)
        {
            (holder as Composite<T>).list.Remove(p);
            return holder;
        }
        else
        {
            return this;
        }
    }
}
