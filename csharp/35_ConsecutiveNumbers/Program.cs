namespace ConsecutiveNumbers;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Cons(new int[] { 5, 1, 4, 3, 2 }));
    }

    public static bool Cons(int[] arr)
    {
        // first, sort the array 
        Array.Sort(arr);

        // then, check if the difference between each element is 1
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i + 1] - arr[i] != 1)
            {
                return false;
            }
        }
        return true;
    }
}
