float? voltage = null;
float? current = null;

ParseArguments(args, ref voltage, ref current);

if (!voltage.HasValue || !current.HasValue)
{
    PrintUsage();
}

float power = CalculatePower(voltage!.Value, current!.Value);

Console.WriteLine($"A voltage of {voltage}V and a current of {current}A results in a power of {power} watts.");

static void ParseArguments(string[] args, ref float? voltage, ref float? current)
{
    if (args.Length != 2 && args.Length != 4)
    {
        PrintUsage();
    }

    if (args.Length == 2)
    {
        try
        {
            voltage = float.Parse(args[0]);
            current = float.Parse(args[1]);
        }
        catch (FormatException)
        {
            PrintUsage();
        }
    }
    else if (args.Length == 4)
    {
        for (int i = 0; i < args.Length; i += 2)
        {
            if (args[i] == "--voltage")
            {
                voltage = float.Parse(args[i + 1]);
            }
            else if (args[i] == "--current")
            {
                current = float.Parse(args[i + 1]);
            }
        }
    }
}

static float CalculatePower(float voltage, float current)
{
    return voltage * current;
}

static void PrintUsage()
{
    Console.WriteLine("Usage:");
    Console.WriteLine("\tdotnet run <voltage> <current>");
    Console.WriteLine("\tdotnet run --voltage <voltage> --current <current>");
    Environment.Exit(1);
}
