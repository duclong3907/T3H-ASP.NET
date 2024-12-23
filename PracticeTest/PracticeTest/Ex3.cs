/*
Bài tập 3: Sắp xếp mảng và tìm kiếm nhị phân
Mục tiêu: Hiểu cách sắp xếp và tìm kiếm trong mảng, áp dụng thuật toán tìm kiếm nhị phân.

Đề bài:
Viết chương trình C# cho phép người dùng nhập vào một mảng số nguyên. Chương trình sẽ:
Sắp xếp mảng theo thứ tự tăng dần (sử dụng thuật toán sắp xếp lựa chọn hoặc sắp xếp nổi bọt).
Yêu cầu người dùng nhập một số để tìm kiếm trong mảng đã sắp xếp, sử dụng thuật toán tìm kiếm nhị phân.
In ra vị trí của số tìm thấy (nếu có) hoặc thông báo không tìm thấy.
Yêu cầu:
Sử dụng thuật toán sắp xếp đơn giản như sắp xếp lựa chọn hoặc sắp xếp nổi bọt.
Sử dụng thuật toán tìm kiếm nhị phân để tìm kiếm phần tử trong mảng đã sắp xếp.
 */

using Library;
namespace PracticeTest;

internal class Ex3
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
        Console.WriteLine("Before sorting: ");
        showArr(arr);

        Console.WriteLine("After sorting: ");
        Sorting.BubbleSortASC(arr);
        showArr(arr);

        Console.WriteLine("Enter a number to search: ");
        int searchNum;
        Validator.InputInteger(Console.ReadLine(), out searchNum);

        //c1: using LinearSearch
        int index = Searching.LinearSearch(arr, searchNum);

        //c2: using BinarySearch
        //int index = Searching.BinarySearch(arr, searchNum);

        Console.WriteLine(index != -1 ? $"Found element {searchNum} at position = {index}" : $"{searchNum} not found!");

    }

    static void showArr(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

}
