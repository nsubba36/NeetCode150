namespace NeetCode.Solutions.ArraysAndHashing;

public class TwoSum
{
    public int[] TwoSumBrute(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target) return [i, j];
            }
        }

        return [];
    }

    public int[] TwoSumDictionary(int[] nums, int target)
    {
        Dictionary<int, int> visited = new();

        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (visited.TryGetValue(complement, out var value))
            {
                return [value, i];
            }
            visited[nums[i]] = i;
        }
        
        return [];
    }
}