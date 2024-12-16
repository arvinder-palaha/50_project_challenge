if (args.Length != 1)
{
    PrintUsage();
}

int number = int.Parse(args[0]);

Console.WriteLine($"{number <= 0}");

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run <number>");
    Environment.Exit(1);
}

