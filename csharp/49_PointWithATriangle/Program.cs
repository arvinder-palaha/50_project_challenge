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
        // first 6 coordinates are the triangle
        // last 2 coordiantes are the point
        // find area of the triangle
        // find area of the triangles made with the point and each two of the triangle points
        // if the sum of the areas of the triangles is equal to the area of the triangle, then the point is within the triangle
        return false;
    }
}
