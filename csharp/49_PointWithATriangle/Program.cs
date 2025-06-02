namespace PointWithATriangle;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Point with a Triangle");
        if (args.Length > 0)
        {
            Console.WriteLine(WithinTriangle(args[0].Split(',').Select(int.Parse).ToArray()));
        }
    }
    
    public static bool WithinTriangle(int[] points)
    {
        return false;
    }
}
