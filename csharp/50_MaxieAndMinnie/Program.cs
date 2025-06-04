namespace MaxieAndMinnie;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Maxie and Minnie");
        if (args.Length > 0)
        {
            Console.WriteLine(MaxieAndMinnie(long.Parse(args[0])));
        }
    }
    
    public static long[] MaxieAndMinnie(long num)
    {
        return [num, num];
    }
}
