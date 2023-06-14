namespace code_signal;

public static class MatrixElementsSum
{
    public static int solution(int[][] matrix)
    {
        int sum = 0;
        for (var row = 0; row < matrix.Length; row++)
        {
            for (var col = 0; col < matrix[row].Length; col++)
            {
                if (row == 0 && matrix[row][col] != 0)
                    sum += matrix[row][col];

                if (row != 0 && matrix[row - 1][col] == 0)
                    matrix[row][col] = 0;

                if (row != 0 && matrix[row][col] != 0)
                    sum += matrix[row][col];
            }
        }
        return sum;
    }
}
