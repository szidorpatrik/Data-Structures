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

    }
}