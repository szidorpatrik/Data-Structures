using System.Numerics;

namespace DataStructuresLibrary
{
    public class MySet<T> where T : IBinaryInteger<T>
{
        private sealed class Node
        {
            public Node? Left { get; set; }
            public Node? Right { get; set; }
            public T Value { get; }

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node? _root;
        public int Count { get; private set; }

        public void Add(T value)
        {
            bool isNewNode = false;
            _root = AddRecursive(_root, value, ref isNewNode);
            if (isNewNode) Count++;
        }

        private Node AddRecursive(Node? current, T value, ref bool isNewNode)
        {
            if (current is null)
            {
                isNewNode = true;
                return new Node(value);
            }

            if (value.CompareTo(current.Value) == 0)
                return current;

            if (value.CompareTo(current.Value) < 0)
                current.Left = AddRecursive(current.Left, value, ref isNewNode);

            if (value.CompareTo(current.Value) > 0)
                current.Right = AddRecursive(current.Right, value, ref isNewNode);

            return current;
        }
    }
}