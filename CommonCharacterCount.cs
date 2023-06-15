namespace code_signal;

public static class CommonCharacterCount
{
    public static int solution(string s1, string s2)
    {
        int count = 0;
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Count the occurrences of each character in s1
        foreach (char c in s1)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        // Check the characters in s2 and decrement the count if a common character is found
        foreach (char c in s2)
        {
            if (charCount.ContainsKey(c) && charCount[c] > 0)
            {
                count++;
                charCount[c]--;
            }
        }

        return count;
    }
}
