/*
 * @lc app=leetcode.cn id=4 lang=csharp
 *
 * [4] 寻找两个有序数组的中位数
 */
// @lc code=start
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;
        int len = m +n;
        int left = -1,right = -1;
        int nums1Idx = 0 ,nums2Idx = 0;
        for(int i = 0 ; i<= len/2; i++){
            left = right;
            if(nums1Idx < m && (nums2Idx >= n || nums1[nums1Idx] < nums2[nums2Idx])){
                right = nums1[nums1Idx++];
            }else{
                right = nums2[nums2Idx++];
            }
        }
        if((m+n)%2 == 0){
            return (double)((left + right)) /2.0;
        }else{
            return right;
        }
    }
}
// @lc code=end

