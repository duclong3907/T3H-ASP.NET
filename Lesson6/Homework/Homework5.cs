using Library;
namespace Homework;
/*
Bài 5: Viết chương trình tìm tất cả các cặp số trong một danh sách mà tổng của chúng bằng một giá trị K.
Input: [1, 3, 4, 2, 5], K = 6
Output: [(1, 5), (2, 4)]
*/

class Homework5
{
    static void Main()
    {
        int n, k;
        Console.WriteLine("Enter n elements: ");
        Validator.InputInteger(Console.ReadLine(), out n);
        List<int> numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter element {i + 1}: ");
            Validator.InputInteger(Console.ReadLine(), out int num);
            numbers.Add(num);
        }

        Console.WriteLine("Enter K: ");
        Validator.InputInteger(Console.ReadLine(), out k);

        Console.Write("List: ");
        ShowingList.Display<int>(numbers);

        Console.WriteLine("Pairs: ");
        FindPairs(numbers, k);
    }

    //C1: Ngắn hơn cơ mà O(n^3)

    //static void FindPairs(List<int> numbers, int k)
    //{
    //    List<Tuple<int, int>> foundPairs = new List<Tuple<int, int>>();
    //    for (int i = 0; i < numbers.Count - 1; i++)
    //    {
    //        for (int j = i + 1; j < numbers.Count; j++)
    //        {
    //            if (numbers[i] + numbers[j] == k)
    //            {
    //                // Kiểm tra xem cặp này đã được tìm thấy chưa
    //                Tuple<int, int> pair = numbers[i] < numbers[j]
    //                    ? Tuple.Create(numbers[i], numbers[j])
    //                    : Tuple.Create(numbers[j], numbers[i]);

    //                // Thêm vào danh sách nếu chưa có trong đó
    //                if (!foundPairs.Contains(pair))
    //                {
    //                    foundPairs.Add(pair);
    //                    Console.Write($"({pair.Item1}, {pair.Item2}), ");
    //                }
    //            }
    //        }
    //    }
    //    Console.WriteLine();
    //}

    //C2: Dài hơn cơ mà O(n^2)
    static void FindPairs(List<int> numbers, int k)
    {
        // Nếu k chẵn => (K/2, K/2)
        if (k % 2 == 0)
        {
            int halfK = k / 2;
            int countHalfK = 0;

            foreach (var num in numbers)
            {
                if (num == halfK)
                {
                    countHalfK++;
                }
            }

            if (countHalfK > 1)
            {
                Console.Write($"({halfK}, {halfK}), ");
            }
        }
        var list = RemoveDuplicates(numbers);

        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] + list[j] == k)
                {
                    Console.Write($"({list[i]}, {list[j]}), ");
                }
            }
        }
        Console.WriteLine();
    }

    static List<int> RemoveDuplicates(List<int> numbers)
    {
        List<int> uniqueNumbers = new List<int>();
        Sorting.SortASC(numbers);

        foreach (int num in numbers)
        {
            if (!uniqueNumbers.Contains(num))
            {
                uniqueNumbers.Add(num);
            }
        }
        return uniqueNumbers;
    }
}
