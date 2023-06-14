namespace code_signal;
public static class AlmostIncreasingSequence
{
    public static bool solution(int[] sequence)
    {
        int length = sequence.Length;

        if (length == 2)
            return true;

        int countOne = 0;
        int countTwo = 0;

        for (int i = 0; i < length - 1; i++)
        {
            if (sequence[i] >= sequence[i + 1])
                countOne++;

            if (i != 0)
            {
                if (sequence[i - 1] >= sequence[i + 1])
                    countTwo++;
            }
        }
        if (countOne == 1 && countTwo <= 1)
            return true;

        return false;
    }
}
