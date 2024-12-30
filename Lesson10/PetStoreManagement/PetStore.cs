namespace PetStoreManagement;

class PetStore
{
    public List<Pet> Pets { get; private set; }
    public PetStore()
    {
        Pets = new List<Pet>();
    }

    public void AddPet(Pet pet)
    {
        Pets.Add(pet);
    }

    public void DisplayAllPets()
    {
        foreach (var pet in Pets)
        {
            Console.WriteLine($"Pet ID: {pet.PetID}, Name: {pet.Name}, Age: {pet.Age}, Human Age: {pet.CalculateHumanAge()}");
            pet.Speak();
            Console.WriteLine();
        }
    }

    public List<Pet> GetPetsByType(Type petType)
    {
        List<Pet> filteredPets = new List<Pet>();

        foreach (var pet in Pets)
        {
            if (pet.GetType() == petType)
            {
                filteredPets.Add(pet);
            }
        }

        return filteredPets; 
    }
}
