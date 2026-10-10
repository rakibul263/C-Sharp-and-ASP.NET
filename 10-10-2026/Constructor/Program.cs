class Student
{
    public string name;
    public int age;
    public Student(string student_name, int student_age)
    {
        name = student_name;
        age = student_age;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("Rakibul", 23);
        Student student2 = new Student("Echa Ali", 32);

        Console.WriteLine(student1.name);
        Console.WriteLine(student2.age);
    }
}