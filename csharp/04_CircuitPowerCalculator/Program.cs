if (args.Length != 2)
{
    PrintUsage();
    return;
}

try
{
    float voltage = float.Parse(args[0]);
    float current = float.Parse(args[1]);

    float power = CalculatePower(voltage, current);

    Console.WriteLine($"A voltage of {voltage}V and a current of {current}A results in a power of {power} watts.");
}
catch (FormatException)
{
    PrintUsage();
}

static float CalculatePower(float voltage, float current)
{
    return voltage * current;
}

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run <voltage> <current>");
}
