/*
Bài tập 1: Đếm số lần xuất hiện của các phần tử trong mảng
Mục tiêu: Sử dụng collection (Dictionary) để lưu trữ và đếm tần suất xuất hiện của các phần tử trong mảng.
Đề bài:
Viết chương trình C# nhận vào một mảng số nguyên từ người dùng. Sau đó, chương trình sẽ:
Đếm số lần xuất hiện của mỗi phần tử trong mảng.
In ra kết quả theo định dạng: phần tử kèm theo số lần xuất hiện của nó.
Yêu cầu:
Sử dụng Dictionary<int, int> để lưu trữ phần tử và số lần xuất hiện của nó.
Nếu phần tử đã tồn tại trong từ điển, tăng giá trị đếm lên.
 */

using Library;
namespace PracticeTest;

class Ex1
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

        Dictionary<int, int> frequencyMap = CountElementFrequency(arr);
        ShowResult(frequencyMap);


    }

    static Dictionary<int, int> CountElementFrequency(int[] arr)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            frequencyMap[num] = frequencyMap.ContainsKey(num) ? frequencyMap[num] + 1 : 1;
        }
        return frequencyMap;
    }

    static void ShowResult(Dictionary<int, int> frequencyMap)
    {
        Console.WriteLine("Result:");
        foreach (var item in frequencyMap)
        {
            Console.WriteLine($"Element {item.Key} appears {item.Value} times.");
        }
    }

}
