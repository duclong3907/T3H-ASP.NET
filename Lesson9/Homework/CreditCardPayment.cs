namespace Homework;

class CreditCardPayment : Payment
{
    public string CreditCardNumber { get; set; }

    public CreditCardPayment(decimal amount, string creditCardNumber) : base(amount)
    {
        Amount = amount;
        CreditCardNumber = creditCardNumber;
    }

    public override void ProcessPayment() => Console.WriteLine($"Đã thanh toán {Amount} VNĐ qua thẻ {CreditCardNumber}");
}
