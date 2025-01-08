namespace CountOnesInBinaryRepOfInteger;

public class Program
{
    public static void Main(string[] args) {}

    public static int CountOnesInBinaryRepOfInteger(int number)
    {
        /// convert number to binary string (base 2)
        string binaryNumberString = Convert.ToString(number, 2);

        /// count the number of 1s in the string
        int count = binaryNumberString.Count(c => c == '1');

        /// return the count
        return count;
    }
}