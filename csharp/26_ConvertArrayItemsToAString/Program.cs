namespace ConvertArrayItemsToAString;

public class Program
{
    public static void Main(string[] args) {}

    public static object[] ParseArray(object[] array)
    {
        return array.Select(item => item.ToString() ?? "").ToArray();
    }
}
