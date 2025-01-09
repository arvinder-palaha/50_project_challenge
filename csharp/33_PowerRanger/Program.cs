namespace PowerRanger;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 3)
        {
            int n = int.Parse(args[0]);
            int a = int.Parse(args[1]);
            int b = int.Parse(args[2]);
            Console.WriteLine(PowerRanger(n, a, b));
        }
        else
        {
            Console.WriteLine("Please provide three arguments: n, a, b");
        }
    }

    public static int PowerRanger(int n, int a, int b)
    {
        int count = 0;
        for (int i = 1; i <= b; i++)
        {
            int raised = (int)Math.Pow(i, n);
            Console.WriteLine($"{raised} {a} {b}");
            if (raised >= a && raised <= b)
                count++;
            if (raised > b)
                break;
        }
        return count;
    }
}
