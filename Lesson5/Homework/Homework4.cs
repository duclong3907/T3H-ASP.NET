namespace Homework;
/*
Bài 4: Viết chương trình  để sắp xếp các phần tử mảng theo thứ tự giảm dần.
Input:
Nhập kích thước của mảng: 3
Nhập 3 phần tử vào mảng:
phần tử - 0 : 5
Phần tử - 1 : 9
phần tử - 3 : 1

Output:
Các phần tử của mảng được sắp xếp giảm dần:
9 5 1
*/
internal class Homework4
{
    static void Main()
    {
        int n;
        Console.WriteLine("Enter n element: ");
        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Invalid input");
            return;
        }
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element - {i}: ");
            if (!int.TryParse(Console.ReadLine(), out int value))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            arr[i] = value;
        }

        SortArrayDescending(arr);

        Console.WriteLine("Sorted array in descending order: ");
        DisplayArray(arr);

    }

    //Bubble sort bọt bọt
    private static void SortArrayDescending(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = arr.Length - 1; j > i; j--)
            {
                if (arr[j] > arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
            }
        }
    }

    private static void DisplayArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
    }

}
