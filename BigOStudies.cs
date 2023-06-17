namespace code_signal;

public static class BigOStudies
{
    public static void printFirst(List<string> items)
    {
        // Accessing the first item of the list in constant time (O(1)).
        // The algorithm has a constant time complexity since it only accesses one item.
        Console.WriteLine(items[0]);
    }

    public static void printAll(List<string> items)
    {
        // Iterating through the list and printing each item.
        // The time complexity is linear (O(n)), where 'n' is the number of items in the list.
        for (int i = 0; i < items.Count; i++)
        {
            // Accessing each item of the list in constant time (O(1)).
            Console.WriteLine(items[i]);
        }
    }

    public static void printBackwards(List<string> items)
    {
        // Iterating through the list in reverse order and printing each item.
        // The time complexity is linear (O(n)), where 'n' is the number of items in the list.
        for (int i = items.Count - 1; i >= 0; i--)
        {
            // Accessing each item of the list in constant time (O(1)).
            Console.WriteLine(items[i]); // BigO(1) 
        }

        // Even if we had two for loops, the time complexity is still linear (O(n)).
        // The constant factors are dropped, keeping only the linear growth.
    }

    public static bool printMatrix(int[][] matrix, int target)
    {
        var rows = matrix.Length;
        var column = matrix[0].Length;

        // Iterating through each cell of the matrix to find the target value.

        // The time complexity is linear (O(n)), where 'n' is the total number of cells in the matrix.
        // In the worst case, it grows linearly too.

        // Iterating through each cell of the matrix, which has 'l' rows and 'c' columns.
        // In the worst case, where 'l' represents the number of rows and 'c' represents the number of columns,
        // the algorithm has a time complexity of O(l * c).
        // The time complexity grows linearly with the number of cells in the matrix.

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (matrix[i][j] == target)
                    return true;
            }
        }
        return false;
    }

    public static bool findInArrayString(char[] array, char target)
    {
        // The time complexity of the `findInArrayString` algorithm is O(n), where n is the length of the input array.
        // In the algorithm, we iterate through each character in the array using a `foreach` loop.Since we visit each element once, the time taken to execute the loop is directly proportional to the size of the input array.
        // Therefore, as the size of the array(n) increases, the time taken to execute the loop and find the target character also increases linearly.Hence, the algorithm has a linear time complexity of O(n).
        var rows = array.Length;
        foreach (char c in array)
        {
            if (c == target)
                return true;
        }
        return false;
    }


    private static char[] Array
    {
        get
        {
            char[] arrayString = { 'a', 'b', 'c', 'd', 'e' };
            return arrayString;
        }
    }

    public static void printBinarySearch(char target, int start, int end)
    {
        // The time complexity of the binary search algorithm is O(log n), where n is the number of elements in the array being searched.
        // In your provided code snippet, you're implementing a recursive binary search algorithm. The algorithm recursively divides the search range in half until the target element is found or the search range is empty.
        // In each recursive step, the search range is halved, which results in reducing the number of elements to search by half.This division by half is what gives binary search its efficiency. As a result, the number of recursive calls required to find the target element grows logarithmically with the number of elements in the array.
        // Therefore, the time complexity of this algorithm is O(log n), making it an efficient search algorithm for sorted arrays.
        if (start > end)
            Console.WriteLine("Not Found");

        var middle = (start + end) / 2;
        if (Array[middle] == target)
            Console.WriteLine($"Found it at index {middle}");

        if (Array[middle] > target)
            printBinarySearch(target, start, middle - 1);

        if (Array[middle] < target)
            printBinarySearch(target, middle + 1, end);
    }
}
