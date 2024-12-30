using PetStoreManagement;

PetStore petStore = new PetStore();


petStore.AddPet(new Dog("D001", "Dog1", 3, "Poodle"));
petStore.AddPet(new Dog("D002", "Dog2", 2, "Shiba"));
petStore.AddPet(new Dog("D002", "Dog3", 4, "Doge"));
petStore.AddPet(new Cat("C001", "Whiskers", 5, "Black"));
petStore.AddPet(new Cat("C002", "Mittens", 1, "White"));

Console.WriteLine("All Pets in the Store:");
petStore.DisplayAllPets();

//filter and display dogs and cats
Console.WriteLine("Pets of Type 'Dog':");
var dogs = petStore.GetPetsByType(typeof(Dog));
foreach (var dog in dogs)
{
    dog.Speak();
}

Console.WriteLine();

Console.WriteLine("Pets of Type 'Cat':");
var cats = petStore.GetPetsByType(typeof(Cat));
foreach (var cat in cats)
{
    cat.Speak();
}
