using NeetCode.Solutions.ArraysAndHashing;

namespace NeetCode.Tests.ArraysAndHashing;

public class GroupAnagramsTest
{
    [Fact]
    public void GroupAnagramsDictionary_MultipleWordsAnagrams_ReturnsValidGroupAnagrams()
    {
        var solution = new GroupAnagrams();
        string[] inputs = ["act", "pots", "tops", "cat", "stop", "hat"];
        List<List<string>> outputs = [["hat"], ["act", "cat"], ["stop", "pots", "tops"]];
        var outputsSorted = outputs.Select(group => group.OrderBy(word => word).ToList()).OrderBy(group => string.Join(",", group)).ToList();
        var result = solution.GroupAnagramsDictionary(inputs);
        var resultSorted = result.Select(group => group.OrderBy(word => word).ToList()).OrderBy(group => string.Join(",", group)).ToList();
        Assert.Equal(outputsSorted, resultSorted);
    }
    
    [Fact]
    public void GroupAnagramsDictionary_SingleWord_ReturnsValidGroupAnagrams()
    {
        var solution = new GroupAnagrams();
        string[] inputs = ["x"];
        List<List<string>> outputs = [["x"]];
        var outputsSorted = outputs.Select(group => group.OrderBy(word => word).ToList()).OrderBy(group => string.Join(",", group)).ToList();
        var result = solution.GroupAnagramsDictionary(inputs);
        var resultSorted = result.Select(group => group.OrderBy(word => word).ToList()).OrderBy(group => string.Join(",", group)).ToList();
        Assert.Equal(outputsSorted, resultSorted);
    }
    
    [Fact]
    public void GroupAnagramsDictionary_SingleEmptyWord_ReturnsValidGroupAnagrams()
    {
        var solution = new GroupAnagrams();
        string[] inputs = [""];
        List<List<string>> outputs = [[""]];
        var outputsSorted = outputs.Select(group => group.OrderBy(word => word).ToList()).OrderBy(group => string.Join(",", group)).ToList();
        var result = solution.GroupAnagramsDictionary(inputs);
        var resultSorted = result.Select(group => group.OrderBy(word => word).ToList()).OrderBy(group => string.Join(",", group)).ToList();
        Assert.Equal(outputsSorted, resultSorted);
    }
}