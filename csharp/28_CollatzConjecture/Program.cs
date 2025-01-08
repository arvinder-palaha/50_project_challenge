using System.Reflection;
using System.Runtime.Versioning;

namespace CollatzConjecture;

public class Program
{
    public static int Collatz(int n)
    {
        if (n <= 0) { throw new ArgumentException("n must be a positive integer"); }
        int steps = 0;
        while (n != 1)
        {
            if (n % 2 == 0) { n /= 2;}
            else { n = n * 3 + 1; }
            steps++;
        }
        return steps;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(0 % 2);
    }
}
