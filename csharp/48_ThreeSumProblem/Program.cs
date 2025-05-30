namespace ThreeSumProblem;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Three Sum Problem");
        if (args.Length > 0)
        {
            Console.WriteLine(ThreeSum(args[0].Split(',').Select(int.Parse).ToArray()));
        }
    }

    public static string ThreeSum(int[] nums)
    {
        return "{ }";
    }
}
