namespace code_signal;

public static class AllLongestString
{
    public static string[] solution(string[] inputArray)
    {
        var longest = 0;
        var tempLongest = 0;
        var tempList = new List<string>();

        foreach (string input in inputArray)
        {
            tempLongest = input.Count();
            if (tempLongest >= longest)
                longest = tempLongest;
        }

        foreach (string input in inputArray)
        {
            if (input.Count() >= longest)
                tempList.Add(input);
        }

        return tempList.ToArray();
    }
}
// var totalItemsInArray = inputArray.Length;
// var totalCharCount = 0;

// foreach (string input in inputArray)
//     totalCharCount += input.Count();

// double average = (double)totalCharCount / totalItemsInArray;
// int roundedValue = (int)Math.Ceiling(average);
// int howManyString = 0;

// foreach (string input in inputArray)
// {
//     if (input.Count() >= roundedValue)
//         howManyString++;
// }

// int count = 0;
// string[] newArray = new string[howManyString];

// foreach (string input in inputArray)
// {
//     if (input.Count() >= roundedValue)
//     {
//         newArray[count] = input;
//         count++;
//     }
// }

// return newArray;