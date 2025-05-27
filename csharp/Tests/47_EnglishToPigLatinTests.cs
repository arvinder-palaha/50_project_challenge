namespace Tests;

using EnglishToPigLatin;

public class EnglishToPigLatinTests
{
    [Theory]
    [InlineData("flag", "agflay")]
    [InlineData("Apple", "Appleyay")]
    [InlineData("button", "uttonbay")]
    [InlineData("", "")]
    [InlineData("I like to eat honey waffles.", "Iyay ikelay otay eatyay oneyhay afflesway.")]
    [InlineData("Do you think it is going to rain today?", "Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?")]
    public void TranslateWord_ReturnsPigLatinWord(string word, string expected)
    {
        var result = Program.Translate(word);
        Assert.Equal(expected, result);
    }
}
