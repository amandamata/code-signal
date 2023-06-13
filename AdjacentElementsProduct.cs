namespace code_signal;
public static class AdjacentElementsProduct
{
    public static int solution(int[] inputArray)
    {
        var maxProduct = int.MinValue;
        for (var i = 0; i < inputArray.Length - 1; i++)
        {
            var product = inputArray[i] * inputArray[i + 1];
            if (product > maxProduct)
                maxProduct = product;
        }
        return maxProduct;
    }
}