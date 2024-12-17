if (args.Length != 2)
{
    PrintUsage();
}

try
{
    float dimension1 = float.Parse(args[0]);
    float dimension2 = float.Parse(args[1]);

    float perimeter = 2 * (dimension1 + dimension2);
    Console.WriteLine(perimeter);
}
catch (FormatException)
{
    PrintUsage();
}

static void PrintUsage()
{
    Console.WriteLine("Usage: Program.exe <length> <width>");
    Environment.Exit(1);
}
