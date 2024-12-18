using System.Runtime.CompilerServices;

if (args.Length != 2)
{
    PrintUsage();
}

try
{
    float baseNumber = float.Parse(args[0]);
    float exponent = float.Parse(args[1]);
    float result = CalculateExponent(baseNumber, exponent);
    Console.WriteLine(result);
}
catch (FormatException)
{
    PrintUsage();
}

static float CalculateExponent(float baseNumber, float exponent)
{
    return MathF.Pow(baseNumber, exponent);
}

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run <base> <exponent>");
    Environment.Exit(1);
}