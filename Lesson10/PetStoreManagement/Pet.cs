namespace PetStoreManagement;

abstract class Pet
{
    public string PetID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void Speak();

    public virtual void Feed() => Console.WriteLine($"{Name} is being fed.");

    public int CalculateHumanAge() => Age * 7;
}
