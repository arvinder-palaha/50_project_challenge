namespace ImaginaryCodingInterview;

public class Program
{
    private const int TotalTimeLimit = 120;
    private const int VeryEasyQuestionTimeLimit = 5;
    private const int EasyQuestionTimeLimit = 10;
    private const int MediumQuestionTimeLimit = 15;
    private const int HardQuestionTimeLimit = 20;

    public static void Main(string[] args){}

    public static string Interview(int[] times, int totalTime)
    {
        if (totalTime > TotalTimeLimit)
            return "disqualified";

        if (times.Length != 8)
            return "disqualified";

        if (times[0] > VeryEasyQuestionTimeLimit || times[1] > VeryEasyQuestionTimeLimit)
            return "disqualified";

        if (times[2] > EasyQuestionTimeLimit || times[3] > EasyQuestionTimeLimit)
            return "disqualified";

        if (times[4] > MediumQuestionTimeLimit || times[5] > MediumQuestionTimeLimit)
            return "disqualified";

        if (times[6] > HardQuestionTimeLimit || times[7] > HardQuestionTimeLimit)
            return "disqualified";

        return "qualified";
    }
}

