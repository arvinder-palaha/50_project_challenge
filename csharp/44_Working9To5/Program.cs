namespace Working9To5;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static double Working9To5(double startHour, double endHour, double hourlyRate, double overtimeMultiplier)
    {
        double result = 0;
        // how many hours before 9
        double hourseBefore9 = Math.Max(0, 9 - startHour);
        result += hourseBefore9 * hourlyRate * overtimeMultiplier;

        // how many hours after 5
        double hoursAfter5 = Math.Max(0, endHour - 17);
        result += hoursAfter5 * hourlyRate * overtimeMultiplier;

        // how many hours between 9 and 5
        double hoursBetween9and5 = endHour - startHour - hourseBefore9 - hoursAfter5;
        result += hoursBetween9and5 * hourlyRate;

        return result;
    }
}
