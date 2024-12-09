using Library;
namespace Homework;
/*
Bài 2: Viết chương trình sắp xếp một danh sách các chuỗi theo độ dài của chúng (tăng dần). 
Nếu hai chuỗi có cùng độ dài, sắp xếp theo thứ tự từ điển.
Input: ["apple", "banana", "kiwi", "pear", "mango"]
Output: ["kiwi", "pear", "apple", "mango", "banana"]
 */
class Homework2
{
    public static void Main()
    {
        List<string> words = new List<string> { "apple", "banana", "kiwi", "pear", "mango" };

        Console.WriteLine("Before sorting:");
        ShowingList.Display<string>(words);

        Console.WriteLine("After sorting:");
        Sorting.SortString(words);
        ShowingList.Display<string>(words);
    }
}
