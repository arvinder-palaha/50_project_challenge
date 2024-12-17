if (args.Length != 2)
{
    PrintUsage();
}

static void PrintUsage()
{
    Console.WriteLine("Usage: Program.exe <length> <width>");
    Environment.Exit(1);
}
