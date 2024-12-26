namespace Homework;

class Product
{
    public string Name { get; set; }
    public decimal BasePrice { get; set; }

    public Product(string name, decimal basePrice)
    {
        Name = name;
        BasePrice = basePrice;
    }

    public virtual decimal CalculatePrice() => BasePrice;

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Tên sản phẩm: {Name}");
        Console.WriteLine($"Giá gốc: {BasePrice}");
    }

}
