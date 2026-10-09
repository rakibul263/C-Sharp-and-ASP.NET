class OddEven
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        if(number % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }
}