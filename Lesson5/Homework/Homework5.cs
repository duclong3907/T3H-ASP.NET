namespace Homework;
/*
Bài 5: Viết chương trình để tìm phần tử lớn thứ hai trong một mảng.
input:
Nhập kích thước của mảng: 5
Nhập 5 phần tử vào mảng:
phần tử - 0 : 2
phần tử - 1 : 9
phần tử - 2 : 1
phần tử - 3 : 4
phần tử - 4 : 6
Output:

Phần tử lớn thứ hai trong mảng là: 6
 */

class Homework5
{
    static void Main()
    {
        Console.WriteLine("Enter n elements:");
        int n;
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

        Console.WriteLine($"Second largest element in the array is: {FindSecondLargestElement(arr)}");

    }

    private static int FindSecondLargestElement(int[] arr)
    {
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        foreach (int num in arr)
        {
            if (num > max1)
            {
                max2 = max1;
                max1 = num;
            }
            else if (num > max2 && num < max1)
            {
                max2 = num;
            }
        }
        return max2;
    }

}



