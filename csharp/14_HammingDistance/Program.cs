if (args.Length != 2)
{
    PrintUsage();
}

string str1 = args[0];
string str2 = args[1];

if (str1.Length != str2.Length)
{
    PrintUsage();
}

int hammingDistance = CalculateHammingDistance(str1, str2);
Console.WriteLine(hammingDistance);

static void PrintUsage()
{
    Console.WriteLine("Usage: dotnet run <string1> <string2>");
    Environment.Exit(1);
}

static int CalculateHammingDistance(string str1, string str2)
{
    int result = 0;
    for (int i = 0; i < str1.Length; i++)
    {
        if (str1[i] != str2[i])
        {
            result++;
        }
    }
    return result;
}