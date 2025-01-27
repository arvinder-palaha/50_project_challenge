namespace AWeekLater;

using System;
using System.Globalization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("A Week Later");
    }

    public static string WeekAfter(string date)
    {
        DateTime dateTime = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime weekLater = dateTime.AddDays(7);
        return weekLater.ToString("dd/MM/yyyy");
    }
}