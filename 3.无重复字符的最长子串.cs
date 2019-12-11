/*
 * @lc app=leetcode.cn id=3 lang=csharp
 *
 * [3] 无重复字符的最长子串
 */
using System.Collections.Generic;
// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)) return 0;
        var m = s.ToCharArray();
        var dic = new Dictionary<char,int>{};
        var index = 0;
        var maxsize = 1;
        int size = 0;
        for(int i = 0 ; i < m.Length ; i++){
            if(!dic.ContainsKey(m[i])){
                dic.Add(m[i],i);
                size ++ ;
                maxsize = size > maxsize ? size : maxsize;
            }else{
                index = dic[m[i]];
                i = index;
                size = 0;
                dic.Clear();
            }
        }
        return maxsize;
    }
}
// @lc code=end

