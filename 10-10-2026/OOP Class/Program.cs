class Student
{
    public string name;
    public int age;
}

class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();

        student1.name = "Rakibul";
        student1.age = 23;

        Console.WriteLine(student1.name);
        Console.WriteLine(student1.age);
    }
}