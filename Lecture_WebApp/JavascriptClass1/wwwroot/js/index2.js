/*
 *
 *  local scope: their life is inside the block statements only
 *  fucntional scope: can be called anywhere in the function and declare any where inside the fucntion
 *  global scope
 */



let p = "20", q = 20
console.log(p == q)

let p = "20", q = 20
console.log(p === q)

/* difference between == and ===
 * == willl compare the values only
 * === will compare the values and data type both
 */