class Animal
{
    private protected string name = "Dog";
}

class Dog : Animal
{
    public void Display()
    {
        Console.WriteLine(name);
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();

        dog.Display();
    }
}