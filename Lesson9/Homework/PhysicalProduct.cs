namespace Homework;

class PhysicalProduct : Product
{
    public double Weight { get; set; }
    public decimal ShippingCost { get; set; }

    public PhysicalProduct(string name, decimal basePrice, double weight, decimal shippingCost) : base(name, basePrice)
    {
        Weight = weight;
        ShippingCost = shippingCost;
    }

    public override decimal CalculatePrice() => BasePrice + ShippingCost;

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Trọng lượng: {Weight} kg");
        Console.WriteLine($"Phí vận chuyển: {ShippingCost}");
    }
}
