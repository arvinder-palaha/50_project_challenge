if (args.Length != 2)
{
    PrintUsage();
}

try
{
    int number1 = int.Parse(args[0]);
    int number2 = int.Parse(args[1]);

    int smallerNumber = GetSmallerNumber(number1, number2);

    Console.WriteLine(smallerNumber);
}
catch (FormatException)
{
    PrintUsage();
}

static int GetSmallerNumber(int number1, int number2)
{
    return number1 < number2 ? number1 : number2;
}

static void PrintUsage()
{
    Console.WriteLine("Usage: smallerNum <number1> <number2>");
    Environment.Exit(1);
}

