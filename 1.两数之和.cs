/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> intStore = new Dictionary<int, int>();    
        for (int i=0; i<nums.Length; i++) {
            if (intStore.ContainsKey(target-nums[i])) {
                return new int[] {intStore[target-nums[i]], i};
            } else {
                intStore[nums[i]] = i;
            }
        }
        return null;

    }
}

