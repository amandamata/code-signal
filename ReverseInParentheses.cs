namespace code_signal;

public static class ReverseInParentheses
{
    public static string solution(string inputString)
    {
        // Find the first closing parenthesis
        int firstClosingParentheses = inputString.IndexOf(')');

        // Base case: if there are no closing parentheses, return the input string
        if (firstClosingParentheses == -1)
            return inputString;

        // Find the last opening parenthesis before the first closing parenthesis
        int lastOpeningParenthesesBeforeTheFirstClosing = inputString.LastIndexOf('(', firstClosingParentheses);

        // Extract the substring between the parentheses
        string subString = inputString.Substring(lastOpeningParenthesesBeforeTheFirstClosing + 1, firstClosingParentheses - lastOpeningParenthesesBeforeTheFirstClosing - 1);

        // Reverse the substring
        char[] subArray = subString.ToCharArray();
        Array.Reverse(subArray);
        string reversedSubString = new string(subArray);

        // Replace the substring (including parentheses) with the reversed substring
        string firstPart = inputString.Substring(0, lastOpeningParenthesesBeforeTheFirstClosing);
        string secondPart = reversedSubString;
        string thirdPart = inputString.Substring(firstClosingParentheses + 1);
        string newString = $"{firstPart}{secondPart}{thirdPart}";

        // Recursively process the new string
        return solution(newString);
    }
}
