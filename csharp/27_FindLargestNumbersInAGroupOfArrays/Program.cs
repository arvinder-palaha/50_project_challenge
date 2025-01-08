namespace FindLargestNumbersInAGroupOfArrays;

public class Program
{
    public static void Main(string[] args) {}

    public static float[] FindLargest(float[][] arrays)
    {
        return arrays.Select(array => array.Max()).ToArray();
    }
}
