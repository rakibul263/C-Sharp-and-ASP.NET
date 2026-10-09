using System.IO.Pipelines;

class AreaOfTriangle
{
    public static void Main(string[] args)
    {
        double baseLength, height, result;

        Console.WriteLine("Triangle Area Calculator : ");

        Console.Write("Enter baseLength : ");
        baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Height : ");
        height = Convert.ToDouble(Console.ReadLine());
        
        result = 0.5 * baseLength * height;

        Console.WriteLine($"Area of Triangle = {result.ToString("F4")}");
    }
}