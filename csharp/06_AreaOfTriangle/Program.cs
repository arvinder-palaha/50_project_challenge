class Program
{
    static void Main(string[] args)
    {
        float? input_base = null;
        float? input_height = null;

        ParseArguments(args, ref input_base, ref input_height);
    }

    private static void ParseArguments(string[] args, ref float? input_base, ref float? input_height)
    {
        if (args.Length != 2)
        {
            PrintUsage();
        }

        Console.WriteLine($"{input_base} {input_height}");
    }

    private static void PrintUsage()
    {
        Console.WriteLine("Usage: dotnet run <base> <height>");
    }
}