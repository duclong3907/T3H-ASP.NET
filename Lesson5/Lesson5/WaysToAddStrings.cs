using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class WaysToAddStrings
    {
        void Main()
        {
            /*
               * Các cách cộng chuỗi 
             */
            //Cách 1: sử dụng toán tử cộng.mỗi lần công chuỗi thì chuỗi mới đc tạo ra và làm tăng cái số lượng bộ nhớ đc cấp phát
            //Hiệu năng kém khi cộng nhiều chuỗi trong 1 vòng lặp
            // Sử dụng tốt nhất: khi số lượng chuỗi nhỏ và ko lặp đi lặp lại

            string result = "Hello" + " " + "world";

            // Cách 2: String.Concat
            // Hiệu năng tốt hơn vì Concat ko tạo ra biến trung gian
            // phù hơp với case khi cần nối 1 số chuỗi cố định
            // Sử dụng tốt nhất: nối chuỗi từ các biến hoặc những giá trị ko đổi
            string str1 = string.Concat("Hello", " ", "world", " 2411");

            // Cách 3: sử string builder
            // được thiết kế để tối ưu cho việc cộng nhiều chuỗi
            // sử dụng tốt nhất: cần cộng nhiều chuỗi trong vòng lặp hoặc xây dựng 1 chuỗi động phức tạp

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello world");
            stringBuilder.Append("2411");
            Console.WriteLine(stringBuilder);

            // Cach 4: string.join
            // Hiệu năng của string.join tốt hơn cách 1 khi cần nối danh sách các chuỗi (Mảng, collection)
            // chỉ cần 1 lần xử lý để nối tất cả các chuỗi trong mảng, trách việc cấp phát nhiều lần vùng nhớ
            // sử dụng tốt nhất: khi nối chuỗi (mảng, collection) với các ký tự phân cách
            string str2 = string.Join(" ", new[] { "Hello", "wold" });

            // Cách 5: Interpolation ($"chuoi")
            //sử dụng tốt nhất: cần tạo ra 1 chuỗi dễ đọc và các giá trị truyền động vào
            string str3 = $"Phạm thành công {str1} {result}";
            string.Format(str1, str2, str3);
        }
    }
}
