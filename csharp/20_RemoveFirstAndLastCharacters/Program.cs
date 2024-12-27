if(args.Length != 1)
{
    PrintUsage();
}

var input = args[0];
var result = RemoveFirstLast(input);

Console.WriteLine(result);

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run \"<string>\"");
    Environment.Exit(1);
}

static string RemoveFirstLast(string input)
{
    if (input.Length <= 2)
    {
        return input;
    }

    return input.Substring(1, input.Length - 2);
}