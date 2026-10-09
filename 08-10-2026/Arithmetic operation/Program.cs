class ArithmeticOperation
{
    public static void Main(string[] args)
    {
        int number1, number2, result;

        Console.Write("Enter a first number : ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a second number : ");
        number2 = Convert.ToInt32(Console.ReadLine());
        
        result = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {result}");
        
        result = number1 - number2;
        Console.WriteLine($"{number1} + {number2} = {result}");

        result = number1 * number2;
        Console.WriteLine($"{number1} + {number2} = {result}");

        result = number1 / number2;
        Console.WriteLine($"{number1} + {number2} = {result}");
    }
}