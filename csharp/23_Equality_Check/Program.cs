namespace EqualityCheck;

public class Program
{
    public static void Main(string[] args) {}

    public static bool CheckEquality(object a, object b)
    {
        if (a.GetType() != b.GetType())
        {
            return false;
        }
        return a.Equals(b);
    }
}
