namespace code_signal;

public static class Add
{
    public static int solution(int param1, int param2)
    {
        int result = 0;
        if ((param1 >= -1000 && param1 <= 1000) && (param2 >= -1000 && param2 <= 1000))
            result = param1 + param2;
        return result;
    }
}