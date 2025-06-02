using System.Xml.XPath;

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
        var triplets = new HashSet<int[]>();

        // are there at least 3 elements? -> return empty array
        if (nums.Length < 3)
        {
            return "{ }";
        }

        // loop through the array using loop index as the first element of a possible 0-sum triplet
        for (int first = 0; first < nums.Length -2; first ++)
        {
            // loop through the array after the first element, using loop index as the second element of a possible 0-sum triplet
            for (int second = first + 1; second < nums.Length - 1; second ++)
            {
                // loop through the array after the second element, using loop index as the third element of a possible 0-sum triplet
                for (int third = second + 1; third < nums.Length; third ++)
                {
                    // if the sum of the three elements is 0, add the triplet to the result
                    Console.WriteLine($"{nums[first]}, {nums[second]}, {nums[third]}");
                    var triplet = new int[] { nums[first], nums[second], nums[third] };
                    if (triplet.Sum() == 0)
                    {
                        if (!CheckIfTripletExists(triplets, triplet))
                        {
                            triplets.Add(triplet);
                        }
                    }
                }
            }
        }

        // return the result
        return triplets.Any()
            ? "{ " + string.Join(", ", triplets.Select(t => $"{{ {string.Join(", ", t)} }}")) + " }"
            : "{ }";
    }

    private static bool CheckIfTripletExists(HashSet<int[]> triplets, int[] triplet)
    {
        return triplets.Any(t => t.SequenceEqual(triplet));
    }
}
