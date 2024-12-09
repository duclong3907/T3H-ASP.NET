namespace Library;

public static class Sorting
{

    public static void SortString (List<string> list)
    {
        int n = list.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = n - 1; j > i; j--)
            {
                if (list[j].Length < list[j - 1].Length ||
                     (list[j].Length == list[j - 1].Length && list[j].CompareTo(list[j - 1]) < 0))
                {
                    Swap(list, j, j - 1);
                }
            }
        }
    }

    //Buble sort tăng
    public static void SortASC(List<int> list)
    {
        int n = list.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = n - 1; j > i; j--)
            {
                if (list[j] < list[j - 1])
                {
                    Swap(list, j, j - 1);
                }
            }
        }
    }

    //sort giảm
    public static void SortDESC(List<int> list)
    {
        int n = list.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = n - 1; j > i; j--)
            {
                if (list[j] > list[j - 1])
                {
                    Swap(list, j, j - 1);
                }
            }
        }
    }

    private static void Swap<T>(List<T> list, int i, int j)
    {
        T temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
}
