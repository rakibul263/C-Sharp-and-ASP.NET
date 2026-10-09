class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        int target = 30;
        bool found = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                found = true;
                Console.WriteLine("Found at index: " + i);
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Not found");
        }
    }
}