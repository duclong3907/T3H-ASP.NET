namespace Library;

public static class Searching
{
    //Linear search (On)
    public static int LinearSearch(int[] arr, int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
            {
                return i;
            }
        }
        return -1;
    }

    //Binary search (Ologn) - force array must be sorted
    public static int BinarySearch(int[] arr, int key)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == key)
            {
                return mid;
            }
            if (arr[mid] < key)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}
