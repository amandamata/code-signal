namespace code_signal;

public static class CenturyFromYear
{
    public static int solution(int year)
    {
        if (year < 1 || year > 2005)
            return 0;

        int century = (year - 1) / 100 + 1;
        return century;
    }
}
