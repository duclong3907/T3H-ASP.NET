namespace Homework;

class DigitalProduct : Product
{
    public double FileSize { get; set; }

    public DigitalProduct(string name, decimal basePrice, double fileSize) : base(name, basePrice)
    {
        FileSize = fileSize;
    }

    public override decimal CalculatePrice() => BasePrice + (decimal)(FileSize * 0.1);

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Dung lượng file: {FileSize} MB");
    }

}
