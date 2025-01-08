namespace ImaginaryCodingInterview;

public class Program
{
    private const int TotalTimeLimit = 120;
    private const int VeryEasyQuestionTimeLimit = 5;
    private const int EasyQuestionTimeLimit = 10;
    private const int MediumQuestionTimeLimit = 15;
    private const int HardQuestionTimeLimit = 20;

    private enum QuestionDifficulty
    {
        VeryEasy1 = 0,
        VeryEasy2 = 1,
        Easy1 = 2,
        Easy2 = 3,
        Medium1 = 4,
        Medium2 = 5,
        Hard1 = 6,
        Hard2 = 7
    }

    public static void Main(string[] args){}

    public static string Interview(int[] times, int totalTime)
    {
        if (totalTime > TotalTimeLimit)
            return "disqualified";

        if (times.Length != 8)
            return "disqualified";

        if (times[(int)QuestionDifficulty.VeryEasy1] > VeryEasyQuestionTimeLimit || times[(int)QuestionDifficulty.VeryEasy2] > VeryEasyQuestionTimeLimit)
            return "disqualified";

        if (times[(int)QuestionDifficulty.Easy1] > EasyQuestionTimeLimit || times[(int)QuestionDifficulty.Easy2] > EasyQuestionTimeLimit)
            return "disqualified";

        if (times[(int)QuestionDifficulty.Medium1] > MediumQuestionTimeLimit || times[(int)QuestionDifficulty.Medium2] > MediumQuestionTimeLimit)
            return "disqualified";

        if (times[(int)QuestionDifficulty.Hard1] > HardQuestionTimeLimit || times[(int)QuestionDifficulty.Hard2] > HardQuestionTimeLimit)
            return "disqualified";

        return "qualified";
    }
}

