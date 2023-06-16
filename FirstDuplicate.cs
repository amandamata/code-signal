namespace code_signal;

public static class FirstDuplicate
{
    public static int solution(int[] a)
    {
        // need to find a duplicated number
        // if there are no duplicated number return -1
        // if there are more than 1, return the first duplicated number, with the minor index
        // a = [2, 1, 3, 5, 3, 2]
        // 3
        int firstIndex = 0;
        Dictionary<int, int> duplicated = new Dictionary<int, int>();

        foreach (int i in a)
        {
            if (duplicated.ContainsKey(i))
            {
                duplicated[i]++;
                if (firstIndex == 0)
                    firstIndex = i;
            }
            else
                duplicated[i] = 1;
        }

        if (firstIndex == 0)
            return -1;
        return firstIndex;
    }
}
