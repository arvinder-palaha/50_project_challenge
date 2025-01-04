namespace ReturnIndexCapitalLatters;

public class Program
{
    public static void Main(string[] args) {}

    public static List<int> ReturnIndexCapitalLatters(string str)
    {
        var result = new List<int>();
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                result.Add(i);
            }
        }
        return result;
    }
}