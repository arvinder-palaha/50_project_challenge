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
        if (points.Length != 8)
        {
            throw new ArgumentException("Points must be an array of 8 integers");
        }

        // first 6 coordinates are the triangle
        int Ax = points[0];
        int Ay = points[1];
        int Bx = points[2];
        int By = points[3];
        int Cx = points[4];
        int Cy = points[5];
        
        // last 2 coordiantes are the point
        int Px = points[6];
        int Py = points[7];
        
        // find area of the triangle
        double area_ABC = area_triangle(Ax, Ay, Bx, By, Cx, Cy);

        // find area of the triangles made with the point and each two of the triangle points
        double area_PAB = area_triangle(Px, Py, Ax, Ay, Bx, By);
        double area_PBC = area_triangle(Px, Py, Bx, By, Cx, Cy);
        double area_PCA = area_triangle(Px, Py, Cx, Cy, Ax, Ay);

        // if the sum of the areas of the triangles is equal to the area of the triangle, then the point is within the triangle
        bool is_within_triangle = area_PAB + area_PBC + area_PCA == area_ABC;
        return is_within_triangle;
    }

    private static double area_triangle(int Ax, int Ay, int Bx, int By, int Cx, int Cy)
    {
        return Math.Abs(Ax * (By - Cy) + Bx * (Cy - Ay) + Cx * (Ay - By)) / 2.0;
    }
}
