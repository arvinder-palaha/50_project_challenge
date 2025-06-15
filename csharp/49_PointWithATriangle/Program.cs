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
        var Ax = points[0];
        var Ay = points[1];
        var Bx = points[2];
        var By = points[3];
        var Cx = points[4];
        var Cy = points[5];
        var Px = points[6];
        var Py = points[7];

        var area1 = Area(Ax, Ay, Bx, By, Px, Py);
        var area2 = Area(Ax, Ay, Cx, Cy, Px, Py);
        var area3 = Area(Bx, By, Cx, Cy, Px, Py);

        if (area1 + area2 + area3 == Area(Ax, Ay, Bx, By, Cx, Cy))
        {
            return true;
        }
        
        return false;
    }

    public static double Area(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
    }
}
