class Student
{
    public string name = "Rakib";

    public void Display()
    {
        Console.WriteLine(name);
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();

        Console.WriteLine(student.name);

        student.Display();
    }
}