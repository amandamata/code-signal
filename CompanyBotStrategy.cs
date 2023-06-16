namespace code_signal;

public static class CompanyBotStrategy
{
    public static double solution(int[][] trainingData)
    {
        // for loop
        // check if the second colun value is equals 1
        // add a counter to the check
        // sum the values

        int count = 0;
        int sum = 0;
        double result = 0;

        for (var i = 0; i < trainingData.Length; i++)
        {
            for (var j = 0; j < trainingData[0].Length; j++)
            {
                if (j == 1)
                {
                    if (trainingData[i][j] != 0 && trainingData[i][j] != -1)
                    {
                        count++;
                        sum += trainingData[i][j - 1];
                    }
                }
                Console.WriteLine($"i[{i}]j[{j}] = {trainingData[i][j]}");
            }
        }

        if (sum == 0 || count == 0)
            return 0;

        result = ((double)sum / count);
        return result;
    }
}
