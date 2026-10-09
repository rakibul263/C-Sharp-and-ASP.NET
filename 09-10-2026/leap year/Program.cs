class LeapYear
{
    public static void Main(string[] args)
    {
        int year;
        Console.Write("Enter year : ");
        year = Convert.ToInt32(Console.ReadLine());

        if(year % 400 == 0)
        {
            Console.WriteLine($"{year} is a leap year.");
        } else if(year % 4 == 0 && year % 100 != 0)
        {
           Console.WriteLine($"{year} is a leap year."); 
        } else
        {
            Console.WriteLine($"{year} is a not leap year.");
        }
    }
}