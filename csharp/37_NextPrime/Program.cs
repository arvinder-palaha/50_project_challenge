namespace NextPrime;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Next prime");
    }

    public static int NextPrime(int n)
    {
        if (IsPrime(n))
        {
            return n;
        }

        return NextPrime(n + 1);
    }

    private static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }

        for (int i = 2; i <= (int)n/2; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
