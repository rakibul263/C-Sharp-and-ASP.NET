class CapitalOrSmall
{
    public static void main(string[] args)
    {
        char latter;
        Console.Write("Enter a letter: ");
        latter = Convert.ToChar(Console.ReadLine());

        if(latter >= 'A' && latter <= 'Z')
        {
            Console.WriteLine($"{latter} is a capital latter.");
        } else
        {
            Console.WriteLine($"{latter} is a small latter.");
        }
    }
}