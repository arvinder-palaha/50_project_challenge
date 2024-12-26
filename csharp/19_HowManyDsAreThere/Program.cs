if (args.Length != 1)
{
    PrintUsage();
}

var input = args[0];
var count = CountDs(input);

Console.WriteLine(count);

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run \"<string>\"");
    Environment.Exit(1);
}

static int CountDs(string input)
{
    return input.ToLower().Count(c => c == 'd');
}

