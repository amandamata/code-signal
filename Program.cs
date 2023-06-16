﻿using code_signal;

Console.WriteLine($"Add = {Add.solution(1, 2)}");
// --------------------------------------------------------------------------------------
Console.WriteLine($"CenturyFromYear = {CenturyFromYear.solution(1996)}");
// --------------------------------------------------------------------------------------
Console.WriteLine($"CheckPalindrome = {CheckPalindrome.solution("aba")}");
// --------------------------------------------------------------------------------------
int[] array = { 5, 1, 2, 3, 1, 4 };
Console.WriteLine($"AdjacentElementsProduct = {AdjacentElementsProduct.solution(array)}");
// --------------------------------------------------------------------------------------
Console.WriteLine($"ShapeArea = {ShapeArea.solution(3)}");
// --------------------------------------------------------------------------------------
int[] array2 = { 6, 2, 3, 8 };
Console.WriteLine($"MakeArrayConsecutive2 = {MakeArrayConsecutive2.solution(array2)}");
// --------------------------------------------------------------------------------------
int[] array3 = { 3, 6, 5, 8, 10, 20, 15 };
Console.WriteLine($"AlmostIncreasingSequence = {AlmostIncreasingSequence.solution(array3)}");
// --------------------------------------------------------------------------------------
int[][] matrix = new int[][]
{
    new int[] { 1, 1, 1, 0 },
    new int[] { 0, 5, 0, 1 },
    new int[] { 2, 1, 3, 10 }
};
Console.WriteLine($"MatrixElementsSum = {MatrixElementsSum.solution(matrix)}");
// --------------------------------------------------------------------------------------
string[] inputArray = { "aba", "aa", "ad", "vcd", "aba" };
Console.WriteLine($"AllLongestString ");
string[] returnedArray = AllLongestString.solution(inputArray);
foreach (string input in returnedArray)
    Console.WriteLine($"{input}");
// --------------------------------------------------------------------------------------
string s1 = "aabcc";
string s2 = "adcaa";
Console.WriteLine($"CommonCharacterCount = {CommonCharacterCount.solution(s1, s2)}");
// --------------------------------------------------------------------------------------
Console.WriteLine($"IsLucky = {IsLucky.solution(1230)}");
// --------------------------------------------------------------------------------------
int[] sortByHeightArray = { -1, 150, 190, 170, -1, -1, 160, 180 };
Console.WriteLine($"SortByHeight ");
int[] sortByHeightArrayReturned = SortByHeight.solution(sortByHeightArray);
foreach (int value in sortByHeightArrayReturned)
    Console.WriteLine($"{value}");
// --------------------------------------------------------------------------------------
Console.WriteLine($"ReverseInParentheses = {ReverseInParentheses.solution("foo(bar(baz))blim")}");
// --------------------------------------------------------------------------------------
int[] reverseInParenthesesArray = { 50, 60, 60, 45, 70 };
Console.WriteLine($"AlternatingSums ");
int[] alternatingSumsArray = AlternatingSums.solution(reverseInParenthesesArray);
foreach (int value in alternatingSumsArray)
    Console.WriteLine($"{value}");
// --------------------------------------------------------------------------------------
Console.WriteLine($"MemoaizationExample {MemoaizationExample.Fibonacci(5)} ");
Console.WriteLine($"MemoaizationExample {MemoaizationExample.Fibonacci(10)} ");
Console.WriteLine($"MemoaizationExample {MemoaizationExample.Fibonacci(20)} ");
// --------------------------------------------------------------------------------------
int[][] trainingData = new int[][]
{
    new int[] { 4, -1 },
    new int[] { 0, 0 },
    new int[] { 5, -1 },
};
Console.WriteLine($"CompanyBotStrategy {CompanyBotStrategy.solution(trainingData)}");
// --------------------------------------------------------------------------------------
int[] firstDuplicateArray = { 2, 1, 3, 5, 3, 2 };
Console.WriteLine($"FirstDuplicate {FirstDuplicate.solution(firstDuplicateArray)}");
// --------------------------------------------------------------------------------------
