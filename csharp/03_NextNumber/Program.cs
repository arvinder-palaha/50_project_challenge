class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            PrintUsage();
            return;
        }

        try
        {
            int number = int.Parse(args[0]);
            int nextNumber = number + 1;

            Console.WriteLine(nextNumber);
        }
        catch (FormatException)
        {
            PrintUsage();
        }
    }

    static void PrintUsage()
    {
        Console.WriteLine("Usage: dotnet run <number>");
    }
}
