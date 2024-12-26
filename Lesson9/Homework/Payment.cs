namespace Homework;

abstract class Payment
{
    public decimal Amount { get; set; }

    public Payment(decimal amount)
    {
        Amount = amount;
    }

    public virtual void ProcessPayment()
    {
        Console.WriteLine($"Đã thanh toán {Amount} VNĐ");
    }
}
