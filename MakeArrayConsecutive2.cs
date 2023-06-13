namespace code_signal;
public static class MakeArrayConsecutive2
{
    public static int solution(int[] statues)
    {
        Array.Sort(statues);
        var difference = statues[^1] - statues[0];
        return difference - (statues.Length - 1);
    }
}
