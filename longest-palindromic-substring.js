/**
 * @param {string} s
 * @return {string}
 */
var longestPalindrome = function(s) {
    if(s.length == 1 || s.length == 0){
        return s
    }
    if(s.length == 2 && s[0]!=s[1]){
        return s[0]
    }
    var res = s[0];
    var ret = " ";
    if(s.length >= 2){
        // situation one ,中间的数字只有一个，  第二种情况 中间的数字有两个。
    for(var i = 1; i < s.length-1 ; i++){
        res = s[i];
        var j = i-1
        var k = i+1
        while(s[j] == s[k] && j >= 0 && k<= s.length ){
            res = s[j] + res + s[k];
            j--;
            k++;
            if(res.length > ret.length){
                ret = res;
            }
        }
    }
    for(var i = 0; i < s.length-1;i++){
        if(s[i] == s[i+1]){
            res = s[i] + s[i+1];
            var j = i-1;
            var k = i+2;
            if(res.length > ret.length) ret = res
            while(s[j] == s[k] && j >= 0 && k<= s.length ){
            res = s[j] + res + s[k];
            j--;
            k++;
            if(res.length > ret.length){
                ret = res;
            }
        }
    }

    }    
    
    }
    
    
    
    
    return ret == " " ? s[0] : ret

};