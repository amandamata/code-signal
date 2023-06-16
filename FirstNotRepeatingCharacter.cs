namespace code_signal;

public static class FirstNotRepeatingCharacter
{
    public static char solution(string s)
    {
        // need to find a duplicated char
        // if there are no duplicated char return __
        // if there are more than 1, return the first not duplicated char, with the minor index
        // a = abacabad
        // c
        int firstIndex = 0;
        var duplicated = new Dictionary<char, int>();
        char[] arrayS = s.ToArray();
        string newString = new string(arrayS);

        if (arrayS.Length == 1)
            return arrayS[0];

        foreach (char i in arrayS)
        {
            if (duplicated.ContainsKey(i))
                duplicated[i]++;
            else
                duplicated[i] = 1;
        }

        char notRepeationChar = duplicated.FirstOrDefault(x => x.Value == 1).Key;
        firstIndex = newString.IndexOf(notRepeationChar);

        if (firstIndex == 0 || firstIndex == -1)
            return '_';

        return notRepeationChar;
    }
}
