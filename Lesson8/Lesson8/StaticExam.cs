using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8;

/*1.
 Static: không cần khởi tạo đối tượng, nhược điểm không thể truy cập vào các thuộc tính, phương thức không phải static, ko có tính chất oop
   static class, 
   static func - Ko phụ thuộc vào đối tượng của lớp (không cần thiết phải khởi tạo instance của lớp chứa nó)
               - Code lưu vào 1 vùng nhớ: code segment
               - biến cục bộ sẽ lưu trong stack
   static variable - là biến dùng chung cho tất cả các đối tượng của lớp
 2. Đều khởi tạo vùng nhớ 1 lần duy nhất cho đến khi application kết thúc
    - vòng đời xuyên suốt cho đến khi kết thúc ứng dụng
 
 3. Phân bổ bộ nhớ trong c#
    - Stack memory: chứa các biến cục bộ, tham số của phương thức và hàm. Sẽ được giải phóng vùng nhớ khi phương thức hoặc hàm kết thúc (tự động giải phóng khi mà các biến ra khỏi phạm vi)
    - Heap memory: lưu trữ các đối tượng, mảng, các biến được tạo ra bởi từ khóa new. Sẽ được giải phóng vùng nhớ khi không còn tham chiếu đến nó (Cứ heap là phải tham chiếu)
    - Static memory: Lưu trữ static variable và const => khơi tạo 1 lần duy nhất của lớp và tồn tại suốt vòng đời của ứng dụng
 
 */
public static class StaticExam
{
    public static int Sum()
    {
        int a = 10;
        int b = 20;
        return a + b;
    }
}

public class Counter
{
    //Count nó sẽ được chia sẻ chung giữa tất cả các đối tượng của lớp Counter
    public static int Count = 0;
    public Counter()
    {
        Count++;
    }
}