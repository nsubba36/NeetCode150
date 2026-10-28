namespace NeetCode.Solutions.ArraysAndHashing;

public class ContainsDuplicate
{
    public bool HasDuplicateBrute(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j]) return true;
            }
        }
        return false;
    }

    public bool HasDuplicateHashSet(int[] nums)
    {
        HashSet<int> visited = new();
        foreach (var num in nums)
        {
            if (!visited.Add(num)) return true;
        }

        return false;
    }
    
    // Hashset method using linq
    public bool HasDuplicateHashSetLinq(int[] nums)
    {
        HashSet<int> visited = new();
        return nums.Any(x => !visited.Add(x));
    }
    
    // Another linq method
    public bool HasDuplicateHashSetDistinct(int[] nums)
    {
        return nums.Distinct().Count() == nums.Length;
    }
}