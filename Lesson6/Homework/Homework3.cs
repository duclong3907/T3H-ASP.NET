using Library;

namespace Homework;
/*
 Bài 3: Viết chương trình sắp xếp danh sách các số nguyên sao cho:
 - Tất cả các số chẵn được xếp trước (tăng dần). Sau đó là các số lẻ (giảm dần).
Input: [3, 1, 4, 5, 2, 6]
Output: [2, 4, 6, 5, 3, 1]
 */
class Homework3
{
    static void Main()
    {
        List<int> numbers = new List<int> { 3, 1, 4, 5, 2, 6 };

        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
            else
            {
                oddNumbers.Add(number);
            }
        }
        Console.WriteLine("Before sorting: ");
        ShowingList.Display<int>(numbers);
        Console.WriteLine();
        Console.WriteLine("After sorting: ");
        Sorting.SortASC(evenNumbers);
        Sorting.SortDESC(oddNumbers);
        evenNumbers.AddRange(oddNumbers);
        ShowingList.Display<int>(evenNumbers);
    }
}
