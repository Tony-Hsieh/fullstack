/* callback
 * https://javascript.info/
 */

function arithmaticOperations(a, b, callback) {
    callback(a,b)
}


function addition(x, y) {
    console.log(x+y)
}

arithmaticOperations(50, 13, addition)

arithmaticOperations(30, 30, function (x, y){
    conosle.log("multiply = "+(x*y))
})

arithmaticOperations(30, 30, (x, y) => conosle.log("multiply = " + (x * y));



