namespace code_signal;

public static class RotateImage
{
    public static int[][] solution(int[][] a)
    {
        // the first row turn into the last column
        // the last row turn into the first column
        // revert the columns
        var length = a.Length;

        for (int row = 0; row < length; row++)
        {
            for (int column = 1; column < length; column++)
            {
                int temp = a[row][column];
                a[row][column] = a[column][row];
                a[column][row] = temp;
            }
        }

        for (int row = 0; row < length; row++)
        {
            for (int column1 = 0, column2 = length - 1; column1 < column2; column1++, column2--)
            {
                var temp = a[row][column1];
                a[row][column1] = a[row][column2];
                a[row][column2] = temp;
            }
        }

        return a;
    }
}
