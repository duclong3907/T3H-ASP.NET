namespace Library;

public static class Sorting
{
    //Bubble sort (On^2)
    public static void BubbleSortASC(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = arr.Length - 1; j > i; j--)
            {
                if (arr[j] < arr[j - 1])
                {
                    Swap(ref arr[j], ref arr[j - 1]);
                }
            }
        }
    }

    public static void BubbleSortDESC(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = arr.Length - 1; j > i; j--)
            {
                if (arr[j] > arr[j - 1])
                {
                    Swap(ref arr[j], ref arr[j - 1]);
                }
            }
        }
    }

    //Selection sort (On^2)
    public static void SelectionSortASC(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                Swap(ref arr[i], ref arr[minIndex]);
            }
        }
    }

    public static void SelectionSortDESC(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] > arr[maxIndex])
                {
                    maxIndex = j;
                }
            }
            if (maxIndex != i)
            {
                Swap(ref arr[i], ref arr[maxIndex]);
            }
        }
    }


    //swap
    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

}
