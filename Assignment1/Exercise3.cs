namespace Assignment1;

public abstract class Animal
{
    public string Name;

    public string GetName()
    {
        return Name;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public abstract void Eat();
}

public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dog is eating");
    }
}

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Enter dog name:");
        var dogName = Console.ReadLine();

        var dog = new Dog();
        dog.SetName("Dog name is: " + dogName);
        
        Console.WriteLine(dog.GetName());
        dog.Eat();
    }
}