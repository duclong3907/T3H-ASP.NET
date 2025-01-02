using Lesson11.Interface;
namespace Lesson11;

public class Booking
{
    public IRoom Room { get; private set; }
    public decimal TotalPrice { get; private set; }

    public Booking(IRoom room, IPricingStrategy pricingStrategy, bool includesBreakfast, bool includesWiFi)
    {
        Room = room;
        TotalPrice = pricingStrategy.CalculatePrice(room, includesBreakfast, includesWiFi);
    }

    public void PrintBookingDetails()
    {
        Console.WriteLine($"Room: {Room.Name}");
        Console.WriteLine($"Total Price: {TotalPrice:C}");
    }
}
