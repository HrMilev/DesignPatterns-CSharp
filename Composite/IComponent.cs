using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IComponent <T>
{
    void Add(IComponent<T> c);
    IComponent<T> Remove(T s);
    IComponent<T> Find(T s);
    string Display(int depth);
    T Item { get; set; }
}
