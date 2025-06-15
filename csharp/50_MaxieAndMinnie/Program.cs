namespace MaxieAndMinnie;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Maxie and Minnie");
        if (args.Length > 0)
        {
            Console.WriteLine(MaxieAndMinnie(long.Parse(args[0])));
        }
    }
    
    public static long[] MaxieAndMinnie(long num)
    {
        // turn the number into a string, or array of digits
        var digits = num.ToString().ToCharArray();

        // count the number of digits
        var digitCount = digits.Length;

        // hold a minimin value and a maximum value
        var minnie = num;
        var maxie = num;

        // loop through each digit, swap it with another digit
        for (int i = 0; i < digitCount; i++)
        {
            for (int j = i + 1; j < digitCount; j++)
            {
                // skip if means there is a leading zero
                if (i == 0 && digits[j] == '0')
                {
                    continue;
                }

                // swap the digits
                var swapped = SwapDigits(digits, i, j);

                // check for min and max
                if (swapped < minnie)
                {
                    minnie = swapped;
                }
                if (swapped > maxie)
                {
                    maxie = swapped;
                }
            }
        }

        return [maxie, minnie];
    }

    private static long SwapDigits(char[] digits, int i, int j)
    {
        var result = (char[])digits.Clone();
        var temp = result[i];
        result[i] = result[j];
        result[j] = temp;
        return long.Parse(new string(result));
    }
}
