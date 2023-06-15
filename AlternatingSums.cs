namespace code_signal;

public static class AlternatingSums
{
    public static int[] solution(int[] a)
    {
        // alternate the values in the array
        // team1 and team2
        // sum the weight of each team and return the array with the weight

        int[] weight = new int[2];
        for (int i = 0; i < a.Length; i++)
        {
            if (i % 2 == 0)
            {
                weight[0] += a[i];
            }
            else
            {
                weight[1] += a[i];
            }
        }
        return weight;
    }
}
