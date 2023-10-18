namespace MyArrayListLibrary;

public class MyArrayList<T>
{
        private T?[] _items;
        private int _size;
        private const int InitialCapacity = 10;

        public int Count => ToArray().Length;
        public bool IsEmpty => _size == 0;

        public MyArrayList()
        {
            Clear();
        }

        public bool Add(T? item)
        {
            EnsureCapacity();
            _items[_size++] = item;
            return true;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index == -1)
                return false;

            for (int i = index; i < _size - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _size--;
            _items[_size] = default;
            return true;
        }

        public void Clear()
        {
            _items = new T[InitialCapacity];
            _size = 0;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (EqualityComparer<T>.Default.Equals(_items[i], item)) return i;
            }
            return -1;
        }

        public T[] ToArray()
        {
            var resized = new T[_size];
            Array.Copy(_items, resized, _size);
            return resized;
        }

        private bool EnsureCapacity()
        {
            if (_size < _items.Length)
            {
                int newCapacity = _items.Length + 1;
                Array.Resize(ref _items, newCapacity);
                return true;
            }

            return false;
        }

        public T? this[int index]
        {
            get
            {
                if (index >= _size)
                    throw new IndexOutOfRangeException();
                return _items[index];
            }
            set
            {
                if (index >= _size)
                    throw new IndexOutOfRangeException();
                _items[index] = value;
            }
        }

        public override string ToString()
        {
            return string.Join(" ", _items);
        }
}