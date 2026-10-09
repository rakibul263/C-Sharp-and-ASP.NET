class LargestNumber
{
    public static void Main(string[] args)
    {
        int number1 = Convert.ToInt32(Console.Read());
        int number2 = Convert.ToInt32(Console.Read());
        int number3 = Convert.ToInt32(Console.Read());

        if(number1 > number2 && number1 > number3)
        {
            Console.WriteLine("Number 1 is largest.");
        }else if(number2 > number1 && number2 > number3)
        {
            Console.WriteLine("Number 2 is largest.");
        } else if(number3 > number1 && number3 > number2)
        {
            Console.WriteLine("Number 3 is largest.");
        }
        else
        {
            Console.WriteLine("Number is equal.");
        }
    }
}