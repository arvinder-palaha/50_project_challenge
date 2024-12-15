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
            float minutes = float.Parse(args[0]);
            float seconds = minutes * 60;
            Console.WriteLine($"{minutes} minutes is {seconds} seconds");
        }
        catch (FormatException)
        {
            PrintUsage();
        }
    }

    static void PrintUsage()
    {
        Console.WriteLine("Usage: dotnet run <minutes>");
    }
}

