if (args.Length > 0)
{
    if (args[0] == "-s" && args.Length > 1)
    {
        string[] stringNumbers = args[1].Split(',');
        int[] numbers = stringNumbers.Select(int.Parse).ToArray();
        FindAndPrintMinMax(numbers);
        return;
    }
    else
    {
        PrintUsage();
    }
}

int[] numbers1 = { 1, 2, 3, 4, 5 };
FindAndPrintMinMax(numbers1);

int[] numbers2 = { 2334454, 5 };
FindAndPrintMinMax(numbers2);

int[] numbers3 = { 1 };
FindAndPrintMinMax(numbers3);

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run");
    Console.WriteLine("Usage: dotnet run -s <numbers>");
    Environment.Exit(1);
}

static void FindAndPrintMinMax(int[] numbers)
{
    int[] minMax = FindMinMax(numbers);
    Console.WriteLine($"[{minMax[0]}, {minMax[1]}]");
}

static int[] FindMinMax(int[] numbers)
{
    int min = numbers.Min();
    int max = numbers.Max();
    return new int[] { min, max };
}