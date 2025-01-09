namespace FindTheVertexOfQuadratic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static double[] FindVertex(int a, int b, int c)
    {
        double x = -b / (2 * a);
        double y = a * x * x + b * x + c;
        return new double[] { x, y };
    }
}
