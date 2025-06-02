namespace ThreeSumProblem;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Three Sum Problem");
        if (args.Length > 0)
        {
            Console.WriteLine(ThreeSum(args[0].Split(',').Select(int.Parse).ToArray()));
        }
    }

    public static string ThreeSum(int[] nums)
    {
        // find all triplets that sum to 0
        // are there at least 3 elements? -> return empty array
        if (nums.Length < 3)
        {
            return "{ }";
        }

        // loop through the array using loop index as the first element of a possible 0-sum triplet
        // loop through the array after the first element, using loop index as the second element of a possible 0-sum triplet
        // loop through the array after the second element, using loop index as the third element of a possible 0-sum triplet
        // if the sum of the three elements is 0, add the triplet to the result
        // return the result
        return "{ }";
    }
}
