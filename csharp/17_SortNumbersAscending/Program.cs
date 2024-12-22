static int[] SortNumbersAscending(int[]? numbers)
{
    int[] result = numbers ?? [];

    Array.Sort(result);

    return result;
}

static void PrintNumbers(int[] numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}

int[] input1 = [1, 2, 10, 50, 5];
int[] input2 = [80, 29, 4, -95, -24, 85];
int[]? input3 = null;
int[] input4 = [];

PrintNumbers(SortNumbersAscending(input1));
PrintNumbers(SortNumbersAscending(input2));
PrintNumbers(SortNumbersAscending(input3));
PrintNumbers(SortNumbersAscending(input4));


