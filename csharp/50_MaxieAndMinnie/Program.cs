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
        // turn number into an array of digits
        // find the max and min digits - maybe sort them by value?
        // get the max possible number
        // get the min possible number
        return new long[] { number, number };
    }
    
}
