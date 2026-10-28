using NeetCode.Solutions.ArraysAndHashing;

namespace NeetCode.Tests.ArraysAndHashing;

public class ContainsDuplicateTest
{
    [Fact]
    public void HasDuplicateBrute_ArrayHasDuplicate_ReturnsTrue()
    {
        var solution = new ContainsDuplicate();
        int[] input = [1, 2, 3, 3];
        var result = solution.HasDuplicateBrute(input);
        Assert.True(result);
    }
    
    [Fact]
    public void HasDuplicateBrute_ArrayDoesNotHaveDuplicate_ReturnsFalse()
    {
        var solution = new ContainsDuplicate();
        int[] input = [1, 2, 3, 4];
        var result = solution.HasDuplicateBrute(input);
        Assert.False(result);
    }
    
    
    // Hashset optimal solution
    [Fact]
    public void HasDuplicateHashSet_ArrayHasDuplicate_ReturnsTrue()
    {
        var solution = new ContainsDuplicate();
        int[] input = [1, 2, 3, 3];
        var result = solution.HasDuplicateBrute(input);
        Assert.True(result);
    }
    
    [Fact]
    public void HasDuplicateHashSet_ArrayDoesNotHaveDuplicate_ReturnsFalse()
    {
        var solution = new ContainsDuplicate();
        int[] input = [1, 2, 3, 4];
        var result = solution.HasDuplicateBrute(input);
        Assert.False(result);
    }
}