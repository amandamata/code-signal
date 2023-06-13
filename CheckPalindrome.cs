using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code_signal;

public static class CheckPalindrome
{
    public static bool solution(string inputString)
    {
        int left = 0;
        int right = inputString.Length - 1;

        while (left < right)
        {
            if (inputString[left] != inputString[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
