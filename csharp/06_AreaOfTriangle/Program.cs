class Program
{
    static void Main(string[] args)
    {
        float? input_base = null;
        float? input_height = null;

        ParseArguments(args, ref input_base, ref input_height);

        float area = CalculateArea(input_base, input_height);

        Console.WriteLine($"{area}");
    }

    private static void ParseArguments(string[] args, ref float? input_base, ref float? input_height)
    {
        if (args.Length != 2)
        {
            PrintUsage();
        }

        try
        {
            input_base = float.Parse(args[0]);
            input_height = float.Parse(args[1]);
        }
        catch (FormatException)
        {
            PrintUsage();
        }
    }

    private static float CalculateArea(float? input_base, float? input_height)
    {
        return input_base!.Value * input_height!.Value / 2;
    }

    private static void PrintUsage()
    {
        Console.WriteLine("Usage: dotnet run <base> <height>");
        Environment.Exit(1);
    }
}