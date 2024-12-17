if (args.Length != 1)
{
    PrintUsage();
}

try
{
    int monthNumber = int.Parse(args[0]);
    string monthName = GetMonthName(monthNumber);
    Console.WriteLine(monthName);
}
catch (FormatException)
{
    PrintUsage();
}

static string GetMonthName(int monthNumber)
{
    if (monthNumber < 1 || monthNumber > 12)
    {
        PrintUsage();
    }
    string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
    return months[monthNumber - 1];
}

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run <month number between 1 and 12>");
    Environment.Exit(1);
}