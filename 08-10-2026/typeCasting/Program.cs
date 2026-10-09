using System.ComponentModel;

class typeCasting
{
    public static void Main(string[] args)
    {
        double salary2 = 34.5;
        Console.WriteLine((int)salary2);

        int age = 23;
        Console.WriteLine(Convert.ToString(age));

        double number = 10.5;
        int number2 = Convert.ToInt32(number);
        Console.WriteLine($"number2 = {number}");

        string name = "rakibul";
        Console.ReadKey();
    }
}

// implicit -> Auto conversion

// explicit conversion