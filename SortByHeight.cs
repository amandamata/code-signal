namespace code_signal;

public static class SortByHeight
{
    public static int[] solution(int[] a)
    {
        var listOfPeople = new List<int>();
        foreach (int people in a)
        {
            if (people != -1)
                listOfPeople.Add(people);
        }

        listOfPeople.Sort();

        var index = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != -1)
            {
                a[i] = listOfPeople[index];
                index++;
            }
        }

        return a;
    }
}
