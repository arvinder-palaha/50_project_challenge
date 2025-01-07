# 26_ConvertArrayItemsToAString

## Description

Create a function that takes an array of integers and strings, converts integers to strings, and returns the array as a string array.

## Examples

```csharp
ParseArray([1, 2, "a", "b"]) ➞ ["1", "2", "a", "b"]
ParseArray(["abc", 123, "def", 456]) ➞ ["abc", "123", "def", "456"]
ParseArray([1, 2, 3, 17, 24, 3, "a", "123b"]) ➞ ["1", "2", "3", "17", "24", "3", "a", "123b"]
ParseArray([]) ➞ []
```