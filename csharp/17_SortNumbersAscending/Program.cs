static int[] SortNumbersAscending(int[]? numbers)
{
    int[] result = numbers ?? [];

    Array.Sort(result);

    return result;
}

static int[] SNAarv(int[] numbers)
{
    PrintNumbers(numbers);
    int lnum = numbers.Length;
    int temp;

    for (int i = 0; i < lnum; i++)
    {
        if (i<lnum-1) {
            if (numbers[i] > numbers[i+1]) {
                temp = numbers[i];
                numbers[i] = numbers[i+1];
                numbers[i+1] = temp;
            }
        }
    }
    PrintNumbers(numbers);
    return numbers;
}

static void PrintNumbers(int[] numbers)
{
    Console.WriteLine(string.Join(", ", numbers));
}

int[] input1 = [1, 2, 10, 50, 5];
int[] input2 = [80, 29, 4, -95, -24, 85];
int[]? input3 = null;
int[] input4 = [];

SNAarv(input1);
SNAarv(input2);

PrintNumbers(SortNumbersAscending(input1));
PrintNumbers(SortNumbersAscending(input2));
PrintNumbers(SortNumbersAscending(input3));
PrintNumbers(SortNumbersAscending(input4));


