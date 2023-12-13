using System.Xml;

namespace DataStructuresLibrary;

public class MyLinkedList<T>
{
    public class Node
    {
        public T Value { get; internal set; }
        public Node? Next { get; internal set; }
    }

    public Node? Head { get; private set; }
    public int Count { get; private set; }

    public void Add(T item)
    {
        Node newNode = new()
        {
            Value = item,
            Next = Head
        };

        Head = newNode;
        Count++;
    }
}