namespace code_signal;

public static class CompanyBotStrategy
{
    public static double solution(int[][] trainingData)
    {
        int count = 0;
        int sum = 0;

        foreach (var data in trainingData)
        {
            int answerTime = data[0];
            int correcness = data[1];

            if (correcness == 1)
            {
                sum += answerTime;
                count++;
            }
        }

        if (count == 0)
            return 0;

        double average = (double)sum / count;
        return average;
    }
}
