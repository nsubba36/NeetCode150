namespace NeetCode.Solutions.ArraysAndHashing;

public class ValidAnagram
{
    public bool IsAnagramSorted(string s, string t)
    {
        var sArr = s.ToCharArray();
        var tArr = t.ToCharArray();
        Array.Sort(sArr);
        Array.Sort(tArr);
        var sStr = string.Join("", sArr);
        var tStr = string.Join("", tArr);
        
        return sStr == tStr;
    }

    public bool IsAnagramDictionary(string s, string t)
    {
        if (s.Length != t.Length) return false;
        
        Dictionary<char, int> visited = new();

        for (var i = 0; i < s.Length; i++)
        {
            if (!visited.TryAdd(s[i], 1)) visited[s[i]]++;
            if (!visited.TryAdd(t[i], -1)) visited[t[i]]--;
        }

        foreach (var chr in visited)
        {
            if (chr.Value != 0) return false;
        }
        
        return true;
    }
    
    // array based checking
    public bool IsAnagramArray(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var visited = new int[26];

        for (var i = 0; i < s.Length; i++)
        {
            visited[s[i] - 'a']++;
            visited[t[i] - 'a']--;
        }

        return visited.All(v => v == 0);
    }

}