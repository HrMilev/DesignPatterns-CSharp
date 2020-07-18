using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Client
{
    static void Main(string[] args)
    {
        IComponent<string> pictureFirst = new Component<string>("Me on the Beach");
        IComponent<string> pictureSecond = new Component<string>("Me on the Mountin");
        IComponent<string> pictureThird = new Component<string>("Me on the Tree");

        IComponent<string> album = new Composite<string>("Dream album");

        album.Add(pictureFirst);
        album.Add(pictureSecond);
        album.Add(pictureThird);

        Console.WriteLine(album.Display(5));

        album.Remove("Me on the Beach");

        Console.WriteLine();

        Console.WriteLine(album.Display(5));

    }
}
