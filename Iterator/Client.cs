using System;

namespace Iterator
{
    public class Client
    {
        public static void Main()
        {
            var tree = new CompleteBinaryTree<int>(1);
            tree.AddNode(2).AddNode(3).AddNode(5).AddNode(7).AddNode(11).AddNode(13).AddNode(17);
            IIterator<int> iterator = tree.GetIterator();

            while (iterator.HasNext)
            {
                Console.WriteLine(iterator.Current());
            }
        }
    }
}
