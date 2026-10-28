using NeetCode.Solutions.ArraysAndHashing;

namespace NeetCode.Tests.ArraysAndHashing;

public class TopKFrequentElementsTest
{
    [Fact]
    public void TopKFrequentElements_MultipleElements_ReturnsTwoElements()
    {
        var solution = new TopKFrequentElements();
        int[] inputs = [1, 2, 2, 3, 3, 3];
        const int k = 2;
        int[] output = [2, 3];
        var result = solution.TopKFrequentBucket(inputs, k);
        Array.Sort(output);
        Array.Sort(result);
        Assert.Equal(output, result);
    }
    
    [Fact]
    public void TopKFrequentElements_SingleElements_ReturnsOneElements()
    {
        var solution = new TopKFrequentElements();
        int[] inputs = [7,7];
        const int k = 1;
        int[] output = [7];
        var result = solution.TopKFrequentBucket(inputs, k);
        Assert.Equal(output, result);
    }
}