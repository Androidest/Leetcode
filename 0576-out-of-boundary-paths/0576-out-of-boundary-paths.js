/**
 * @param {number} m
 * @param {number} n
 * @param {number} maxMove
 * @param {number} startRow
 * @param {number} startColumn
 * @return {number}
 */
var findPaths = function(m, n, maxMove, startRow, startColumn) {
    let MOD = 1000000007;
    if (maxMove === 0)
        return 0
    
    let memo = new Array(m)
    for(let i=0; i<m; ++i) {
        memo[i] = new Array(n)
        for (let j = 0; j < n; ++j)
            memo[i][j] = new Array(maxMove)
    }
    
    const recursive = (x, y, leftMoves) => {
        if (leftMoves >= 0) {
            if (x < 0 || x === m || y < 0 || y === n) {
                return 1
            }
            else if (memo[x][y][leftMoves] === undefined){
                let nextMove = leftMoves-1
                memo[x][y][leftMoves] = 
                    recursive(x+1, y, nextMove) +
                    recursive(x, y+1, nextMove) +
                    recursive(x-1, y, nextMove) +
                    recursive(x, y-1, nextMove)
            }
            return memo[x][y][leftMoves] % MOD
        }
        else {
            return 0
        }
    }
    return recursive(startRow, startColumn, maxMove)
};