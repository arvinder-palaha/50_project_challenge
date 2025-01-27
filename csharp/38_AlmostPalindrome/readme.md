# 38_AlmostPalindrome

A string is an almost-palindrome if, by changing only one character, you can make it a palindrome. Create a function that returns true if a string is an almost-palindrome and false otherwise.

## Examples

```csharp
AlmostPalindrome("abcdcbg") ➞ true
// Transformed to "abcdcba" by changing "g" to "a".

AlmostPalindrome("abccia") ➞ true
// Transformed to "abccba" by changing "i" to "b".

AlmostPalindrome("abcdaaa") ➞ false
// Can't be transformed to a palindrome in exactly 1 turn.

AlmostPalindrome("1234312") ➞ false
```
