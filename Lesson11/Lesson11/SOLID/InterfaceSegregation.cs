using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.SOLID
{
    public interface IAnimal
    {
        public void Fly();
        public void Swim();
        public void Walk();
        public void Run();

    }

    public class Dog : IAnimal
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine("Dog can run");
        }

        public void Swim()
        {
            Console.WriteLine("Dog can swim");
        }

        public void Walk()
        {
            Console.WriteLine("Dog can walk");
        }
    }

    public interface IFlyAble
    {
        public void Fly();
    }
    public interface IRunAble
    {
        public void Run();
    }
    public interface ISwimAble
    {
        public void Swim();
    }


    public class Dog1 : ISwimAble, IRunAble
    {
        public void Run()
        {
            Console.WriteLine("Allow run");
        }

        public void Swim()
        {
            Console.WriteLine("Allow swim");
        }
    }

}
