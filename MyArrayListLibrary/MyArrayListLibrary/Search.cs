using System.Collections;

namespace MyArrayListLibrary;

public class Search
{
    public static int LinearSearch<T>(T[] array, T whatToSearch)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (Comparer.Default.Compare(array[i], whatToSearch) == 0)
            {
                return i;
            }
        }

        return -1;
    }

    public static int BinarySearch<T>(T[] array, T whatToSearch)
    {
        int beginning = 0;
        int end = array.Length - 1;

        while (beginning <= end)
        {
            int middle = (beginning + end) / 2;
            if (Comparer.Default.Compare(array[middle], whatToSearch) == 0) return middle;
            if(Comparer.Default.Compare(array[middle], whatToSearch) < 0)
            {
                beginning = middle + 1;
            }
            else if (Comparer.Default.Compare(array[middle], whatToSearch) > 0)
            {
                end = middle - 1;
            }
        }
        return -1;
    }
}