float? years = null;

ParseArguments(args, ref years);

Console.WriteLine($"{years} years is {CalculateDays(years!.Value)} days.");

static float CalculateDays(float years)
{
    return years * 365;
}

static void ParseArguments(string[] args, ref float? years)
{
    if (args.Length != 1)
    {
        PrintUsage();
    }

    try
    {
        years = float.Parse(args[0]);
    }
    catch (FormatException)
    {
        PrintUsage();
    }
}

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run <age>");
    Environment.Exit(1);
}
