namespace Homework;

class Order
{
    public List<Product> Products { get; set; }

    public void AddProduct(Product product) => Products.Add(product);
    public void CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in Products)
        {
            totalPrice += product.CalculatePrice();
        }
        Console.WriteLine($"Tổng giá trị đơn hàng: {totalPrice}");
    }

    public void DisplayOrderDetails()
    {
        foreach (var product in Products)
        {
            product.DisplayInfo();
        }
    }
}
