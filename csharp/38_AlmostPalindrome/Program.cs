namespace AlmostPalindrome;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Almost Palindrome");
    }

    public static bool AlmostPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        int diffCount = 0;

        for (int i = 0; i < s.Length / 2; i++)
        {
            if (s[left] != s[right])
            {
                diffCount++;
            }

            left++;
            right--;
        }

        return diffCount == 1;
    }
}
