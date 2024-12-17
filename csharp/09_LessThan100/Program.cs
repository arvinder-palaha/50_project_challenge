if (args.Length != 2)
{
    PrintUsage();
}

try
{
    float number1 = float.Parse(args[0]);
    float number2 = float.Parse(args[1]);

    Console.WriteLine($"{number1 + number2 < 100}");
}
catch (FormatException)
{
    PrintUsage();
}

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run <number1> <number2>");
    Environment.Exit(1);
}