
namespace CsharpConsole.Polymorphism.Good;

public abstract class Animal
{
    public string Name { get; }
    public string Breed { get; }
    public string Color { get; }

    public Animal(string name, string breed, string color)
    {
        Name = name;
        Breed = breed;
        Color = color;
    }

    public abstract void Eat();
    public abstract void MakeSound();

    public void Sleep()
    {
        Console.WriteLine("Sleeping");
    }
}

public class Dog : Animal
{
    public Dog(string name, string breed, string color) : base(name, breed, color)
    {

    }
    public override void Eat()
    {
        Console.WriteLine("Eating");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Woff");

    }
}


public class Cat : Animal
{
    public Cat(string name, string breed, string color) : base(name, breed, color)
    {

    }
    public override void Eat()
    {
        Console.WriteLine("Eating");
    }

    public override void MakeSound()
    {
        Console.WriteLine("meaw...");

    }
}

public class PetShopEntrySystem
{
    private List<Animal> animals;

    public PetShopEntrySystem()
    {
        animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public IEnumerable<Animal> GetAnimals()
    {
        return animals;
    }
}

public class PetshopEntrySimulator
{
    public static void Main()
    {
        // entries of dogs

        Animal dog = new Dog("Max", "Golden Retriever", "Golden");
        Animal dog2 = new Dog("Luna", "Sibarian Husky", "Grey/White");
        Animal dog3 = new Dog("Duke", "Labrador Retriever", "Chocolate Brown");

        PetShopEntrySystem entrySystem = new PetShopEntrySystem();
        entrySystem.AddAnimal(dog);
        entrySystem.AddAnimal(dog2);
        entrySystem.AddAnimal(dog3);

        Animal cat1 = new Cat("Whiskers", "Persian", "White");
        Animal cat2 = new Cat("Mittens", "Maine Coon", "Grey/Tabby");
        Animal cat3 = new Cat("Ginger", "British Shorthair", "Orange/Ginger");

        entrySystem.AddAnimal(cat1);
        entrySystem.AddAnimal(cat2);
        entrySystem.AddAnimal(cat3);

        IEnumerable<Animal> animals = entrySystem.GetAnimals();

        DisplayAnimals(animals);
    }

    private static void DisplayAnimals(IEnumerable<Animal> animals)
    {
        foreach (var animal in animals)
        {
            Console.WriteLine($"Name: {animal.Name}, Breed : {animal.Breed}, Color: {animal.Color}");
        }
    }
}
