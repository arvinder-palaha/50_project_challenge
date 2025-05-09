# 50 Project Challenge: Csharp

https://www.youtube.com/watch?v=343EWZS9O88&t=186s

The aim is to complete 50 "small" projects, of about 100 lines of code each.
The number of projects will give a good range of topics.
The size of the projects will give a good feedback look on progress.

## Strategy

Use this resource at (edabit)[https://edabit.com/challenges/csharp] to get project ideas.
Start with 10 of the easiest projects, and work up to the harder ones for each decade.

## Setting up the solution

```powershell
dotnet new sln -n csharp
```

## Creating a new project

```powershell
mkdir <project-name>
cd <project-name>
dotnet new console
cd ..
dotnet sln add <project-name>
```

Add a reference to the project in the Tests.csproj file in the Tests folder.

```xml
<ProjectReference Include="..\<project-name>\<project-name>.csproj" />
```

Create a test for the project in the Tests folder.

## Projects

- Very easy
  - [x] [01_SumTwoNumbers](https://edabit.com/challenge/xfRucdwGksiyjZq4K)
  - [x] [02_ConvertMinutesToSeconds](https://edabit.com/challenge/bizjGL4wyd8PwR4Ke)
  - [x] [03_NextNumber](https://edabit.com/challenge/RzkLShpDgDqG3c45H)
  - [x] [04_CircuitPowerCalculator](https://edabit.com/challenge/L2fwjYi9YixY8kJfK)
  - [x] [05_ConvertAgeToDays](https://edabit.com/challenge/nkkKguC5TgWnBiMLA)
  - [x] [06_AreaOfTriangle](https://edabit.com/challenge/aiaLK9Tg6qc8sLDjv)
  - [x] [07_RemainderOfTwoNumbers](https://edabit.com/challenge/4p5WBxogs2ENAb4Wu)
  - [x] [08_LessThenOrEqualToZero](https://edabit.com/challenge/7KX5NogxnTzrKEd5P)
  - [x] [09_LessThan100](https://edabit.com/challenge/3ZwEJFANGaSpqnzrs)
  - [x] [10_FindPerimeterOfRectangle](https://edabit.com/challenge/5JzZhNdpRkDKsWwFW)

- Easy
  - [x] [11_NumberToMonthName](https://edabit.com/challenge/uevxL5FNM77otyo9Z)
  - [x] [12_FindBiggestAndSmallestNumber](https://edabit.com/challenge/uevxL5FNM77otyo9Z)
  - [x] [13_ToThePowerOf](https://edabit.com/challenge/esARjHfWfdRP6ePEC)
  - [x] [14_HammingDistance](https://edabit.com/challenge/K49LXsoMmS6tXxP7R)
  - [x] [15_ShuffleTheName](https://edabit.com/challenge/c4W4BNymgCC5WkfHp)
  - [x] [16_SmallerStringNumber](https://edabit.com/challenge/uBqpafqjoYNPuQ7Pr)
  - [x] [17_SortNumbersAscending](https://edabit.com/challenge/RocWAnyqu5J4fiZxS)
  - [x] [18_HackerSpeak](https://edabit.com/challenge/7nzfry4P3WrrL7t38)
  - [x] [19_HowManyDsAreThere](https://edabit.com/challenge/YxoGXwpApf9De7y5w)
  - [x] [20_RemoveFirstAndLastCharacters](https://edabit.com/challenge/hjFH2T4Gay7m9ka2m)

- Medium
  - [x] [21_ArrayOfMultiples](https://edabit.com/challenge/2QvnWexKoLfcJkSsc)
  - [x] [22_ReverseTheCase](https://edabit.com/challenge/99oN5igrbXddAjHEL)
  - [x] [23_Equality_Check](https://edabit.com/challenge/Q7g8sfg7DJq6CyMMu)
  - [x] [24_ReturnIndexCapitalLatters](https://edabit.com/challenge/Q7g8sfg7DJq6CyMMu)
  - [x] [25_FindTheBomb](https://edabit.com/challenge/JYEufqRvkusjr5R58)
  - [x] [26_ConvertArrayItemsToAString](https://edabit.com/challenge/hqTYj7NbLnCcjxryi)
  - [x] [27_FindLargestNumbersInAGroupOfArrays](https://edabit.com/challenge/nermqxzovZbfFBC9X)
  - [x] [28_CollatzConjecture](https://edabit.com/challenge/F6m5ZRyzK5fmqTrBG)
  - [x] [29_CharactersCounterpartCharCode](https://edabit.com/challenge/zaokQWNdEudmFWpk7)
  - [x] [30_CountOnesInBinaryRepOfInteger](https://edabit.com/challenge/zn3A3AAzoE7vezw7Q)

- Hard
  - [x] [31_IsTheDieLoaded](https://edabit.com/challenge/nH26ehGyyWw86Nsko)
  - [x] [32_ImaginaryCodingInterview](https://edabit.com/challenge/dZeNE4BJhyNgA99Fq)
  - [x] [33_PowerRanger](https://edabit.com/challenge/McGCFZYn8ikn3GSqz)
  - [x] [34_FindTheVertexOfQuadratic](https://edabit.com/challenge/TH8Y97XYtGgbDW8Qw)
  - [x] [35_ConsecutiveNumbers](https://edabit.com/challenge/TAZywz6R2hu9tDQWc)
  - [x] [36_TrackTheRobot](https://edabit.com/challenge/g88PKZrCY6sWPBva7)
  - [x] [37_NextPrime](https://edabit.com/challenge/FKb8JY75nkaHz7B3F)
  - [x] [38_AlmostPalindrome](https://edabit.com/challenge/t6R99zCQ7nesR7Rdk)
  - [x] [39_AWeekLater](https://edabit.com/challenge/y4esBva2cYph5QKg5)
  - [x] [40_CountDuplicateCharacters](https://edabit.com/challenge/wXCzoLtvvEEYBs3p9)

- Very Hard
  - [x] [41_SimplifiedFraction](https://edabit.com/challenge/3wT3QcDdfvMR3amjc)
  - [x] [42_MaximumOccurrence](https://edabit.com/challenge/vtdfueRCmpRGyLAGs)
  - [ ] [43_TrackTheRobotPart3](https://edabit.com/challenge/6S2aJYTjAka94muDT)
  - [ ] [44_Working9To5](https://edabit.com/challenge/rkzH6YsPNgoJjn75i)
  - [ ] [45_KnightsOnABoard](https://edabit.com/challenge/EwAXuk4urzK8WkRGw)

- Expert
  - [ ] [46_MiserableParodyOfACalculator](https://edabit.com/challenge/u2j86CBJibQA5KzQp)
  - [ ] [47_EnglishToPigLatin](https://edabit.com/challenge/u2j86CBJibQA5KzQp)
  - [ ] [48_ThreeSumProblem](https://edabit.com/challenge/wrxoYop5uZKG4nNSb)
  - [ ] [49_PointWithATriangle](https://edabit.com/challenge/F2o3AGSk4NEctvieS)
  - [ ] [50_MaxieAndMinnie](https://edabit.com/challenge/nMW5Tb8odgy3ePvGy)
