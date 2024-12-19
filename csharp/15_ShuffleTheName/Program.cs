if (args.Length != 1)
{
    PrintUsage();
}

string name = args[0];
string[] nameParts = name.Split(' ');
string firstName = nameParts[0];
string lastName = nameParts[1];

Console.WriteLine($"{lastName} {firstName}");

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run \"<name>\"");
    Environment.Exit(1);
}
