class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            PrintUsage();
        }

        int number1 = int.Parse(args[0]);
        int number2 = int.Parse(args[1]);

        int remainder = number1 % number2;

        Console.WriteLine($"{remainder}");
    }

    private static void PrintUsage()
    {
        Console.WriteLine("Usage: dotnet run <number1> <number2>");
        Environment.Exit(1);
    }
}