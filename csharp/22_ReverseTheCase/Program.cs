namespace ReverseTheCase;

public static class Program
{
    public static string ReverseTheCase(string str)
    {
        char[] charArray = str.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLower(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
            else
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
        }
        return new string(charArray);
    }

    public static void Main(string[] args) {}
}