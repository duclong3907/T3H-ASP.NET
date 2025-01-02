using Lesson11.Interface;
namespace Lesson11;

public abstract class Room : IRoom
{
    public string Name { get; protected set; }
    public decimal BasePrice { get; set; }
}
