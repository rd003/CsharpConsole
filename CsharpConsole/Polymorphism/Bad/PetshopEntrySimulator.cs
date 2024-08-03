

namespace CsharpConsole.Polymorphism.Bad;

public class Dog
{
    public string Name { get; }
    public string Breed { get; }
    public string Color { get; }

    public Dog(string name, string breed, string color)
    {
        Name = name;
        Breed = breed;
        Color = color;
    }

    public void Eat()
    {
        Console.WriteLine("Eating");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping");
    }

    public void MakeSound()
    {
        Console.WriteLine("Woff!");
    }
}

public class Cat
{
    public string Name { get; }
    public string Breed { get; }
    public string Color { get; }

    public Cat(string name, string breed, string color)
    {
        Name = name;
        Breed = breed;
        Color = color;
    }

    public void Eat()
    {
        Console.WriteLine("Eating");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping");
    }

    public void MakeSound()
    {
        Console.WriteLine("Meaw...");
    }
}

public class PetShopEntrySystem
{
    private List<Dog> dogs;
    private List<Cat> cats;
    public PetShopEntrySystem()
    {
        dogs = new List<Dog>();
        cats = new List<Cat>();
    }

    public void AddDog(Dog dog)
    {
        dogs.Add(dog);
    }

    public void AddCat(Cat cat)
    {
        cats.Add(cat);
    }

    public IEnumerable<Dog> GetDogs()
    {
        return dogs;
    }

    public IEnumerable<Cat> GetCats()
    {
        return cats;
    }
}


public class PetshopEntrySimulator
{
    public static void Main()
    {
        Dog dog1 = new Dog("Max", "Golden Retriever", "Golden");
        Dog dog2 = new Dog("Luna", "Sibarian Husky", "Grey/White");
        Dog dog3 = new Dog("Duke", "Labrador Retriever", "Chocolate Brown");

        PetShopEntrySystem petShopEntrySystem = new PetShopEntrySystem();
        petShopEntrySystem.AddDog(dog1);
        petShopEntrySystem.AddDog(dog2);
        petShopEntrySystem.AddDog(dog3);

        var dogs = petShopEntrySystem.GetDogs();
        DisplayDogs(dogs);

        Cat cat1 = new Cat("Whiskers", "Persian", "White");
        Cat cat2 = new Cat("Mittens", "Maine Coon", "Grey/Tabby");
        Cat cat3 = new Cat("Ginger", "British Shorthair", "Orange/Ginger");
        petShopEntrySystem.AddCat(cat1);
        petShopEntrySystem.AddCat(cat2);
        petShopEntrySystem.AddCat(cat3);

        var cats = petShopEntrySystem.GetCats();

        DisplayCats(cats);

    }

    private static void DisplayCats(IEnumerable<Cat> cats)
    {
        foreach (var cat in cats)
        {
            Console.WriteLine($"Name: {cat.Name}, Breed: {cat.Breed} and Color: {cat.Color}");
        }
    }

    private static void DisplayDogs(IEnumerable<Dog> dogs)
    {
        foreach (var dog in dogs)
        {
            Console.WriteLine($"Name: {dog.Name}, Breed: {dog.Breed} and Color: {dog.Color}");
        }
    }
}
