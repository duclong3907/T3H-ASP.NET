using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8;

public class Delegate
{
    //Delegate in c#
    //Định nghĩa về delegate
    //Delegate sẽ cho phép truyền và gọi các hàm như một đối tượng
    //Mục đích: Xây dựng ứng dụng linh hoạt và dễ scale
    //Danh sách tham số truyền vào delegate phải trùng với danh sách tham số của hàm sử dụng cho delegate
    //Single delegate: chỉ trỏ tới một hàm
    public delegate void DisplayMessage(string message);

    //Định nghĩa ra hàm cho delegate sử dụng
    public static void ShowMessage(string message)
    {
        Console.WriteLine("Mesage: " + message);
    }

    public static void DoWork(DisplayMessage callback)
    {
        // Logic 1
        Console.WriteLine($"Proccesing.........");
        // Mô phỏng thực hiện 1 logic 2
        Thread.Sleep(4000);  // chúng ta đang xử lý 1 logic gì đây
                             // callback => thực hiện 1 delegate
        callback("Work is Done");

    }

    static void Main(string[] args)
    {
        //Khởi tạo delegate và trỏ tới hàm showMessage
        DisplayMessage message = new DisplayMessage(ShowMessage);

        //thực thi delegate
        message("Hello World");

        //c2: 
        DisplayMessage del2 = ShowMessage;
        del2("Hello World 2");

        DoWork(result => Console.WriteLine(result));
    }
}
