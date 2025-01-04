public class Program
{
    public static int[] ArrayOfMultiples(int num, int length)
    {
        int[] result = new int[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = num * (i + 1);
        }
        return result;
    }

    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: ArrayOfMultiples <number> <length>");
            return;
        }

        int num = int.Parse(args[0]);
        int length = int.Parse(args[1]);
        int[] result = ArrayOfMultiples(num, length);
        Console.WriteLine(string.Join(", ", result));
    }
}

