using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.SOLID;

public abstract class Bird
{
    // hàm logic nghiệp vu chung cho các đối tương con kế thừa và tự xử lý theo logic của class con
    public abstract void Fly();
}

public class ChimEn : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Chim en có thể bay");
    }
}

public class DaiBang : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Đại bàng có thể bay");
    }
}

public class ChimCanhCut : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException(); //vi phạm nguyên tắc Liskov Substitution
    }
}

//solution
public interface IFlyingBird
{
    void Fly();
}
public interface IWalkingBird
{
    void Walk();
}

public class ChimEn1 : IFlyingBird
{
    public void Fly()
    {
        Console.WriteLine("Chim en có thể bay");
    }
}

public class DaiBang1 : IFlyingBird
{
    public void Fly()
    {
        Console.WriteLine("Đại bàng có thể bay");
    }
}

public class ChimCanhCut1 : IWalkingBird
{


    public void Walk()
    {
        Console.WriteLine("Da dieu co the chay");
    }
}