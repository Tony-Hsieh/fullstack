/*
 *  local scope :- their life is inside the block  only where they are created. Use let keyword to create it
 *  functional scope :- can be called anywhere in the function and declare any where inside the function. 
 *                      use var keyword to create it
 *  global scope :- can be called through the javascript code. do not use any keyword to create global variables
 */


function printLoop() {
    for (i = 0; i < 10; i++) {
        console.log("inside loop " + i);
    }

    console.log("outside loop" + i);
}

printLoop();
console.log("outside function " + i)


var x = "20";
console.log(typeof x)
x = false;
console.log(typeof x)

let p = "20", q = 20
console.log(p === q)

/*
 *  difference between == and ===
 *  == will compare the values only
 *  === will compare the values and data type both
 */