namespace NeetCode.Solutions.ArraysAndHashing;

public class TopKFrequentElements
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> freq = new();

        foreach (var num in nums)
        {
            if (!freq.TryAdd(num, 1)) freq[num]++;
        }

        var elems = new int[k];

        var sorted = freq.OrderByDescending(x => x.Value);

        int count = 0;

        foreach (var elem in sorted)
        {
            if (count >= k) break;
            
            elems[count] = elem.Key;
            count++;
        }
        
        return elems;
    }
    
    public int[] TopKFrequentBucket(int[] nums, int k)
    {
        Dictionary<int, int> freq = new();

        foreach (var num in nums)
        {
            if (!freq.TryAdd(num, 1)) freq[num]++;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var (key, value) in freq)
        {
            buckets[value] ??= [];
            buckets[value].Add(key);
        }

        List<int> result = new();

        for (var i = buckets.Length - 1; i > 0; i--)
        {
            if (buckets[i] == null) continue;
            foreach (var bucket in buckets[i])
            {
                result.Add(bucket);
                if (result.Count == k) return result.ToArray();
            }
        }
        
        return result.ToArray();
    }
}