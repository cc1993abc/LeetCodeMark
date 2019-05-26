/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function(s) {
    var res = new Set()
    var maxsize = 0
    if(s.length == 1){
        return 1
    }
    var beforesize = 0
    for(var i = 0 ;i<s.length-1;i++){
        res.add(s[i]);
        beforesize = 1;
        for(var j = i+1; j<s.length;j++){
        res.add(s[j])
        if(res.size>maxsize){
            maxsize = res.size
        }
        if(res.size == beforesize){
            beforesize = 0;
            res.clear();
            break
        }
            beforesize = res.size
        }

    }
    return maxsize
};