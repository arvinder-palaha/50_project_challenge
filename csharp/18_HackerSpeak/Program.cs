if (args.Length != 1)
{
    PrintUsage();
}

var input = args[0];
var hackerSpeak = ConvertToHackerSpeak(input);

Console.WriteLine(hackerSpeak);

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run \"<string>\"");
    Environment.Exit(1);
}

static string ConvertToHackerSpeak(string input)
{
    return input.Replace("a", "4").Replace("e", "3").Replace("i", "1").Replace("o", "0").Replace("s", "5");
}

