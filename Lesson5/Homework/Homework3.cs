namespace Homework;
/*
Bài 3: Viết một phương thức để đảo ngược một chuỗi đầu vào. Sử dụng phương thức này để đảo ngược chuỗi được nhập từ bàn phím.
Ví dụ:
Input: "hello"
Output: "olleh"
 */
class Homework3
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine($"Reversed string: {ReverseString(input)}");
    }

    private static string ReverseString(string input)
    {
        input = input.Trim();
        char[] arr = input.ToCharArray();
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            arr[arr.Length - 1 - i] = input[i];
        }
        return new string(arr);
    }
}

