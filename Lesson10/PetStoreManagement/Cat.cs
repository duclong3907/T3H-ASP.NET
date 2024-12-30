namespace PetStoreManagement;

class Cat : Pet
{
    public string Color { get; set; }
    public Cat(string petID, string name, int age, string color)
    {
        PetID = petID;
        Name = name;
        Age = age;
        Color = color;
    }

    public override void Speak() => Console.WriteLine($"{Name} says: Meow Meow Meow!");

    public override void Feed() => Console.WriteLine($"The cat {Name} is eating cat food.");
}
