namespace Lesson8;

internal class FuncDelegate
{
    static void Main()
    {
        //Func: Delegate có kiểu trả về
        //Cú pháp theo dạng lambda expression
        Func<int, int, int> add = (a, b) => a + b;

        Func<int> getRendomNumber1 = () => new Random().Next(1, 100);
        Console.WriteLine("Random number: " + getRendomNumber1());

        Console.WriteLine("Sum: "+ add(10,40));

        //Action: Delegate không có kiểu trả về
        Action<string> printMessage = (message) => Console.WriteLine("Message: " + message);
        printMessage("Hello Action delegate");

        //Predicate: Delegate trả về kiểu bool, có thể sử dụng cho các phương thức kiểm tra điều kiện
        Predicate<int> isEven = (number) => number % 2 == 0; 
        Console.WriteLine("Is even: " + isEven(10)); //true or false
    }
}
