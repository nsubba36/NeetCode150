using NeetCode.Solutions.ArraysAndHashing;

namespace NeetCode.Tests.ArraysAndHashing;

public class TwoSumTest
{
    [Fact]
    public void TwoSum_4Elements_ReturnsIndices()
    {
        var solution = new TwoSum();
        int[] input = [3,4,5,6];
        var target = 7;
        var result = solution.TwoSumDictionary(input, target);
        int[] expected = [0, 1];
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void TwoSum_3Elements_ReturnsIndices()
    {
        var solution = new TwoSum();
        int[] input = [4,5,6];
        var target = 10;
        var result = solution.TwoSumDictionary(input, target);
        int[] expected = [0, 2];
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void TwoSum_2Elements_ReturnsIndices()
    {
        var solution = new TwoSum();
        int[] input = [5,5];
        var target = 10;
        var result = solution.TwoSumDictionary(input, target);
        int[] expected = [0, 1];
        Assert.Equal(expected, result);
    }
}