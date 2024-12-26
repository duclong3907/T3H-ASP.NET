namespace Homework;

class PayPalPayment : Payment
{
    public string PayPalAccount { get; set; }

    public PayPalPayment(decimal amount, string payPalAccount) : base(amount)
    {
        Amount = amount;
        PayPalAccount = payPalAccount;
    }

    public override void ProcessPayment() => Console.WriteLine($"Đã thanh toán {Amount} VNĐ qua tài khoản PayPal {PayPalAccount}");
}
