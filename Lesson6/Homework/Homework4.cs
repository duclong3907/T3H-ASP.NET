using Library;
namespace Homework;
/*
Bài 4: Cho một danh sách chứa các số nguyên từ 1 đến n nhưng thiếu một số. Hãy tìm số bị thiếu đó.
Input: [1, 2, 4, 5, 6] (với n = 6)
*/
class Homework4
{
    static void Main()
    {
        Console.WriteLine("Enter n");
        int n;
        Validator.InputInteger(Console.ReadLine(), out n);

        List<int> numbers = new List<int>();
        Console.WriteLine($"Enter the {n-1} elements of the list [1, {n}] (no duplicates)::");
        int num;
        for(int i = 0; i < n-1; i++)
        {
            Console.WriteLine($"Number {i+1}");
            Validator.InputInteger(Console.ReadLine(), out num);
            if(num > 0 && num <= n && !IsElementInList(numbers, num))
            {
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine($"Please enter a number between [1, {n}] and no duplicate values");
                i--;
            }

        }
        Console.Write("List: ");
        Sorting.SortASC(numbers);
        ShowingList.Display<int>(numbers);
        Console.WriteLine($"The missing number is: {FindMissingNumber(numbers, n)}");

    }

    static int FindMissingNumber(List<int> numbers, int n)
    {
       int sum = n* (n + 1) / 2;
       int sumElementsOfList = 0;
       for(int i = 0; i < numbers.Count; i++)
       {
            sumElementsOfList += numbers[i];
       }
       return sum - sumElementsOfList;
    }

    static bool IsElementInList(List<int> list, int element)
    {
        foreach (int num in list)
        {
            if (num == element)
            {
                return true; 
            }
        }
        return false;
    }

}
