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
        // turn the number into a string, or array of digits
        // count the number of digits
        // hold a minimin value and a maximum value
        // loop through each digit, swap it with another digit
        // make a long from the digits
        // check for min and max
        return [num, num];
    }
}
