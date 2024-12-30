namespace PetStoreManagement;

class Dog : Pet
{
    public string Breed { get; set; }

    public Dog(string petID, string name, int age, string breed)
    {
        PetID = petID;
        Name = name;
        Age = age;
        Breed = breed;
    }

    public override void Speak() => Console.WriteLine($"{Name} says: Woof Woof Woof!");

    public override void Feed() => Console.WriteLine($"The dog {Name} is eating dog food.");

}
