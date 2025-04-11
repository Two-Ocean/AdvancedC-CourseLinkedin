PetOwner petOwner = new PetOwner
{
    Name = "Sia",
    Pets = new List<Pet> {
        new Dog { Name = "Sia's Dog", Age= 5, isTrained = true },
        new Cat { Name = "Sia's Cat", Age = 3, isDeclawed = true}
    }
};

Console.WriteLine($"{petOwner.Name}'s Pets");
foreach(Pet p in petOwner.Pets)
{
    Console.WriteLine($"Pet name: {p.Name}, Pet age: {p.Age}");
    if (p is Dog dog)
    {
        Console.WriteLine($"Trained: {dog.isTrained}");
    }
    else if (p is Cat cat) 
    {
        Console.WriteLine($"Declawed: {cat.isDeclawed}");
    }
}


Console.ReadLine();