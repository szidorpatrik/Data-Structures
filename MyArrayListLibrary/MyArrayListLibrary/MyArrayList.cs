namespace MyArrayListLibrary;

public class MyArrayList
{
    private string[] items;
    private int size;
    private const int InitialCapacity = 10;
    
    public int Count
    {
        get { return size; }
    }
    
    public bool IsEmpty
    {
        get { return size == 0; }
    }
    
    public MyArrayList()
    {
        items = new string[InitialCapacity];
        size = 0;
    }
    
    public bool Add(string item)
    {
        EnsureCapacity();
        items[size++] = item;
        return true;
    }
    
    public bool Remove(string item)
    {
        int index = IndexOf(item);
        if (index == -1)
            return false;

        for (int i = index; i < size - 1; i++)
        {
            items[i] = items[i + 1];
        }

        size--;
        items[size] = null; 
        return true;
    }
    
    public void Clear()
    {
        items = Array.Empty<string>();
        size = 0;
    }
    
    public int IndexOf(string item)
    {
        for (int i = 0; i < size; i++)
        {
            if (items[i] == item) return i;
        }
        return -1;
    } 
    
    public string[] ToArray()
    {
        var resized = items;
        Array.Resize(ref resized, size);
        return resized;
    }
    
    private bool EnsureCapacity()
    {
        if (size == items.Length)
        {
            int newCapacity = items.Length * 2;
            Array.Resize(ref items, newCapacity);
            return true;
        }

        return false;
    }
    
    public string this[int index] {
        get => index >= size ? throw new IndexOutOfRangeException() : items[index];
        set => items[index] = value;
    }
}