using NeetCode.Solutions.ArraysAndHashing;

namespace NeetCode.Tests.ArraysAndHashing;

public class ValidAnagramTest
{
    [Fact]
    public void ValidAnagramDictionary_IsAnagram_ReturnsTrue()
    {
        var solution = new ValidAnagram();
        string inputS = "racecar", inputT = "carrace";
        var result = solution.IsAnagramDictionary(inputS, inputT);
        Assert.True(result);
    }
    
    [Fact]
    public void ValidAnagramDictionary_NotAnagram_ReturnsTrue()
    {
        var solution = new ValidAnagram();
        string inputS = "jar", inputT = "jam";
        var result = solution.IsAnagramDictionary(inputS, inputT);
        Assert.False(result);
    }
    
    [Fact]
    public void ValidAnagramDictionary_SingleCharacterAnagram_ReturnsTrue()
    {
        var solution = new ValidAnagram();
        const string inputS = "x", inputT = "x";
        var result = solution.IsAnagramDictionary(inputS, inputT);
        Assert.True(result);
    }
}