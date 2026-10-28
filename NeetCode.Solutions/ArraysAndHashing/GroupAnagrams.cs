namespace NeetCode.Solutions.ArraysAndHashing;

public class GroupAnagrams
{
    public List<List<string>> GroupAnagramsSorted(string[] strs)
    {
        Dictionary<string, List<string>> visited = new();

        foreach (var word in strs)
        {
            var wordArr = word.ToCharArray();
            Array.Sort(wordArr);
            var key = string.Join("", wordArr);
            if (!visited.TryAdd(key, [word]))
            {
                visited[key].Add(word);
            }
        }

        return [.. visited.Values];
    }

    public List<List<string>> GroupAnagramsDictionary(string[] strs)
    {
        Dictionary<string, List<string>> visited = new();

        foreach (var word in strs)
        {
            var counts = new int[26];

            foreach (var chr in word)
            {
                counts[chr - 'a']++;
            }

            var key = string.Join(",", counts);

            if (!visited.TryAdd(key, [word]))
            {
                visited[key].Add(word);
            }
        }
        
        return [.. visited.Values];
    }
}