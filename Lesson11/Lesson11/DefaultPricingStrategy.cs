using Lesson11.Interface;
namespace Lesson11;

public class DefaultPricingStrategy : IPricingStrategy
{
    public decimal CalculatePrice(IRoom room, bool includesBreakfast, bool includesWiFi)
    {
        decimal price = room.BasePrice;
        if (includesBreakfast) price += 20m;
        if (includesWiFi) price += 10m;
        return price;
    }
}
