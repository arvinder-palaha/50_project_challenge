namespace MaxieAndMinnie;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Maxie and Minnie");
        if (args.Length > 0)
        {
            Console.WriteLine(Maxmin(long.Parse(args[0])));
        }
    }
    
    public static long[] Maxmin(long number)
    {
        return new long[] { number, number };
    }
    
}
