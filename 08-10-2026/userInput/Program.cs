class userInput
{
    public static void Main()
    {
        string? studentName;
        int? studentAge;

        Console.Write("Enter You Name : ");
        studentName = Console.ReadLine();

        Console.Write("Enter Your Age : ");
        studentAge = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"Name = {studentName}");
        Console.WriteLine($"Age = {studentAge}");

        Console.ReadKey();
    }
}