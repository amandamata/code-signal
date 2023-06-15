namespace code_signal;

public static class ReverseInParentheses
{
    public static string solution(string inputString)
    {
        // find the first closing parentheses
        // find the last openning parentheses before que closing parentheses
        // extract the substring using the closing and openning values
        // revert
        // replace the string

        int firstClosingParentheses = inputString.IndexOf(')');

        if (firstClosingParentheses == -1)
            return inputString;

        int lastOpeningParentheses = inputString.LastIndexOf('(', firstClosingParentheses);

        string subString = inputString.Substring(lastOpeningParentheses + 1, firstClosingParentheses - lastOpeningParentheses - 1);

        char[] reversedArray = subString.ToArray();
        Array.Reverse(reversedArray);
        string reversedSubstring = new string(reversedArray);

        string firstPart = inputString.Substring(0, lastOpeningParentheses);
        string secondPart = reversedSubstring;
        string thirdPart = inputString.Substring(firstClosingParentheses + 1);

        string newString = $"{firstPart}{secondPart}{thirdPart}";
        return solution(newString);
    }
}
