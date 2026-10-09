class Program
{
    static void MyMethod(string country = "Bangladesh")
    {
        Console.WriteLine(country);
    }
    public static void Main(string[] args)
    {
        MyMethod();
        MyMethod("India");
    }
}