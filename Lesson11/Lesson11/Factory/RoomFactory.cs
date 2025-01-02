using Lesson11.Concrete;
using Lesson11.Interface;
namespace Lesson11.Factory;

public class RoomFactory
{
    public static IRoom CreateRoom(string roomType)
    {
        return roomType switch
        {
            "Standard" => new StandardRoom(),
            "Deluxe" => new DeluxeRoom(),
            "Suite" => new SuiteRoom(),
            _ => throw new ArgumentException("Invalid room type")
        };
    }
}
