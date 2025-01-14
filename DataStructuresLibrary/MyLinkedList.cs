using System.Text.Json.Serialization;
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

    public int Count
    {
        get => GetCount();
    }

    public void Add(T item)
    {
        Node newNode = new()
        {
            Value = item,
            Next = Head
        };

        Head = newNode;
    }

    public void InsertAt(int index, T item)
    {
        if (index < 0) throw new ArgumentOutOfRangeException();

        Node newNode = new()
        {
            Value = item
        };

        if (Head is null)
        {
            Head = newNode;
            return;
        }

        Node current = Head;
        Node previous = null;

        IncreasePointerToIndex(index, ref current, ref previous);

        if (current is null && previous != null)
        {
            previous.Next = newNode;
        }

        if (previous is null)
        {
            Head = newNode;
            newNode.Next = current;
            return;
        }

        previous.Next = newNode;
        newNode.Next = current;
    }

    private int GetCount()
    {
        int count = 0;
        Node current = Head;

        while (current != null)
        {
            current = current.Next;
            count++;
        }

        return count;
    }

    public void Remove(T item)
    {
        if (Head is null) throw new ArgumentException("The linked list is empty!");

        Node? current = Head;
        Node? previous = null;

        IncreasePointerToItem(item, ref current, ref previous);

        if (current is null) throw new ArgumentException("This item does not exists!");

        if (previous == null)
        {
            Head = current.Next;
        }
        else
        {
            previous.Next = current.Next;
        }
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index > Count) throw new ArgumentOutOfRangeException();
        if (Head is null) throw new ArgumentException("The linked list is empty!");

        Node? current = Head;
        Node? previous = null;

        IncreasePointerToIndex(index, ref current, ref previous);

        if (current is null) throw new ArgumentOutOfRangeException();

        if (previous == null)
        {
            Head = current.Next;
        }
        else
        {
            previous.Next = current.Next;
        }
    }

    private static void IncreasePointerToIndex(int index, ref Node current, ref Node previous)
    {
        int counter = 0;
        while (current != null && counter != index)
        {
            previous = current;
            current = current.Next;
            counter++;
        }
    }

    private void IncreasePointerToItem(T item, ref Node current, ref Node? previous)
    {
        while (current != null && !current.Value.Equals(item))
        {
            previous = current;
            current = current.Next;
        }
    }
}