namespace Library;

public static class ShowingList
{
    public static void Display<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Console.Write($"{item}, ");
        }
        Console.WriteLine();
    }

    public static void DisplayList<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine();
    }
}
