namespace DataStructuresLibrary;

public class MyStack<T>
{
    private int _currentIndex;
    public int Size { get; private set; }
    private readonly T[] _items;

    public int Count => _currentIndex + 1;

    public MyStack(int size)
    {
        if (size < 1) throw new ArgumentException("Size must be greater than 0");

        Size = size;
        _items = new T[Size];
        _currentIndex = -1;
    }

    public void Push(T item)
    {
        if (_currentIndex + 1 >= Size) throw new ArgumentException("Stack Overflow");
        _items[++_currentIndex] = item;
    }

    public T Pop()
    {
        if (Count < 1) throw new ArgumentException("Stack Underflow");
        return _items[_currentIndex--];
    }

    public T[] ToArray() => _items[..(_currentIndex + 1)];
    
    public override string ToString() => "[" + string.Join(", ", ToArray()) + "]";
}