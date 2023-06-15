namespace code_signal;

public static class IsLucky
{
    public static bool solution(int n)
    {
        string nToString = n.ToString();
        double middleValue = Math.Ceiling((double)nToString.Length / 2);

        string[] nToArray = nToString.Select(c => c.ToString()).ToArray();

        var firstHalf = new List<int>();
        var seconHalf = new List<int>();

        for (var i = 0; i < nToArray.Length; i++)
        {
            if (i < middleValue)
                firstHalf.Add(Convert.ToInt32(nToArray[i]));
            else
                seconHalf.Add(Convert.ToInt32(nToArray[i]));
        }

        int firstHalfSum = 0;
        foreach (var item in firstHalf)
            firstHalfSum += item;

        int seconHalfSum = 0;
        foreach (var item in seconHalf)
            seconHalfSum += item;

        return firstHalfSum == seconHalfSum;
    }
}
/*
ChatGPT solution
public static bool IsLucky(int n)
{
    string ticketNumber = n.ToString();
    int halfLength = ticketNumber.Length / 2;
    int sumFirstHalf = 0;
    int sumSecondHalf = 0;

    for (int i = 0; i < halfLength; i++)
    {
        sumFirstHalf += int.Parse(ticketNumber[i].ToString());
        sumSecondHalf += int.Parse(ticketNumber[halfLength + i].ToString());
    }

    return sumFirstHalf == sumSecondHalf;
}
*/