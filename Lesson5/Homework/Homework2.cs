namespace Homework;
/*Bài 2: Tạo một struct tên là Point với hai thuộc tính X và Y (kiểu double).
- Viết một chương trình để khởi tạo một điểm và in ra tọa độ của điểm đó.
- Viết chương trình tính khoảng cách giữa hai điểm trong mặt phẳng 2D. Công thức tính khoảng cách (Xem ảnh Distance trong file đính kèm)
*/
class Homework2
{
    static void Main()
    {
        Point p1 = new Point(9.5, 5.9);
        Console.Write($"Toa do p1: ");
        p1.DisplayInfo();
        Console.WriteLine();
        Console.Write($"Toa do p2: ");
        Point p2 = new Point(3.5, 7.9);
        p2.DisplayInfo();

        Console.WriteLine($"Distance between p1 and p2: {Point.CalculateDistance(p1, p2)}");
    }
}
