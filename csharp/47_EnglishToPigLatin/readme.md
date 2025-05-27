# 47: English to Pig Latin Translator

## Description

Pig latin has two very simple rules:

    If a word starts with a consonant move the first letter(s) of the word, till you reach a vowel, to the end of the word and add "ay" to the end.
        have ➞ avehay
        cram ➞ amcray
        take ➞ aketay
        cat ➞ atcay
        shrimp ➞ impshray
        trebuchet ➞ ebuchettray
    If a word starts with a vowel add "yay" to the end of the word.
        ate ➞ ateyay
        apple ➞ appleyay
        oaken ➞ oakenyay
        eagle ➞ eagleyay

Write two functions to make an English to pig latin translator. The first function TranslateWord(word) takes a single word and returns that word translated into pig latin. The second function TranslateSentence(sentence) takes an English sentence and returns that sentence translated into pig latin.

## Examples

```csharp
TranslateWord("flag") ➞ "agflay"
TranslateWord("Apple") ➞ "Appleyay"
TranslateWord("button") ➞ "uttonbay"
TranslateWord("") ➞ ""
TranslateSentence("I like to eat honey waffles.") ➞ "Iyay ikelay otay eatyay oneyhay afflesway."
TranslateSentence("Do you think it is going to rain today?") ➞ "Oday ouyay inkthay ityay isyay oinggay otay ainray odaytay?"
```

## Notes

- Regular expressions will help you not mess up the punctuation in the sentence.
- If the original word or sentence starts with a capital letter, the translation should preserve its case (see examples #2, #5 and #6).