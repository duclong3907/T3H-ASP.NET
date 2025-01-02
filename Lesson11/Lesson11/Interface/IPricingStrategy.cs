namespace Lesson11.Interface;

public interface IPricingStrategy
{
    decimal CalculatePrice(IRoom room, bool includesBreakfast, bool includesWiFi);
}
