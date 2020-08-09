using System.Collections.Generic;

namespace Iterator
{
    public class CompleteBinaryTree<T> : IIterable<T>
    {
        private class Node
        {
            public Node(T value)
            {
                Value = value;
            }

            public T Value { get; }

            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }
            public Node Parent { get; set; }
            public Node RightSibling { get; set; }
        }

        private class BFSIterator : IIterator<T>
        {
            private Queue<Node> queue;

            public BFSIterator(Node root)
            {
                queue = new Queue<Node>();
                queue.Enqueue(root);
            }
            public bool HasNext => queue.Count > 0;

            public T Current()
            {
                var current = queue.Dequeue();
                if (current.LeftChild != null)
                {
                    queue.Enqueue(current.LeftChild);
                }
                if (current.RightChild != null)
                {
                    queue.Enqueue(current.RightChild);
                }
                return current.Value;
            }
        }

        private Node root;
        private Node lastLeaf;
        private Node firstLeaf;

        public CompleteBinaryTree(T value)
        {
            lastLeaf = firstLeaf = root = new Node(value);
        }

        public CompleteBinaryTree<T> AddNode(T value)
        {
            var node = new Node(value);

            if (lastLeaf == root)
            {
                node.Parent = root;
                firstLeaf = lastLeaf = root.LeftChild = node;
            }
            else if (lastLeaf.Parent.RightChild == null)
            {
                node.Parent = lastLeaf.Parent;
                lastLeaf.RightSibling = lastLeaf.Parent.RightChild = node;
                lastLeaf = node;
            }
            else if (lastLeaf.Parent.RightSibling != null)
            {
                node.Parent = lastLeaf.Parent.RightSibling;
                lastLeaf.RightSibling = node.Parent.LeftChild = node;
                lastLeaf = node;
            }
            else
            {
                node.Parent = firstLeaf;
                firstLeaf.LeftChild = node;
                lastLeaf = firstLeaf = node;
            }

            return this;
        }

        public IIterator<T> GetIterator()
        {
            return new BFSIterator(root);
        }
    }
}
