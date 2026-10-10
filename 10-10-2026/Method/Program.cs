
class Student
{
    public string name;
    public int age;

    public void Introduce()
    {
        Console.WriteLine($"My name is {name}");
        Console.WriteLine($"My age is {age}");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();

        student1.name = "Rakib";
        student1.age = 23;

        student1.Introduce();
    }
}