/**
 * @param {number} n
 * @return {number}
 */
var climbStairs = function(n) {
    
    let memo = new Array(n)
    
    let recursiveFunc = (curStep) => {
        
        if (curStep < n) {
            if (!memo[curStep]) {
                let a = recursiveFunc(curStep + 1)    
                let b = recursiveFunc(curStep + 2)
                memo[curStep] = a + b
            }
            return memo[curStep]
            
        } else if (curStep == n) {
            return 1
            
        } else { // curStep > n
            return 0
            
        }
    }
    return recursiveFunc(0)
};


