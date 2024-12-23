/*
Bài tập 2: Tìm cặp phần tử có tổng bằng một giá trị cho trước
Mục tiêu: Sử dụng kỹ thuật tìm kiếm và duyệt mảng để tìm cặp số trong mảng có tổng bằng một giá trị.
Đề bài:
Viết chương trình C# nhận vào một mảng số nguyên và một số nguyên k. Chương trình sẽ:
Tìm tất cả các cặp phần tử trong mảng có tổng bằng k.
In ra các cặp này.
Yêu cầu:
Người dùng nhập vào một mảng số nguyên và giá trị k.
Tìm các cặp số trong mảng mà tổng của chúng bằng k.
Mỗi cặp phần tử chỉ được in ra một lần (không tính cặp ngược lại).
 */

using Library;
namespace PracticeTest;

internal class Ex2
{
    static void Main()
    {
        int n;
        Console.WriteLine("Enter number elements in the arr: ");
        Validator.InputInteger(Console.ReadLine(), out n);

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter element {i + 1}: ");
            Validator.InputInteger(Console.ReadLine(), out arr[i]);
        }

        Console.WriteLine("Enter k:");
        int k;
        Validator.InputInteger(Console.ReadLine(), out k);

        FindPairsWithSumDic(arr, k);

    }

    static void FindPairsWithSumDic(int[] numbers, int K)
    {
        Dictionary<int, int> frequency = new Dictionary<int, int>();

        foreach (int num in numbers)
        {
            int complement = K - num;
            if (frequency.ContainsKey(complement))
            {
                for (int i = 0; i < frequency[complement]; i++)
                {
                    Console.WriteLine($"({complement}, {num})");
                }
            }

            frequency[num] = frequency.ContainsKey(num) ? frequency[num] + 1 : 1;
        }
    }
}
