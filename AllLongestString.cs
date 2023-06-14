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
