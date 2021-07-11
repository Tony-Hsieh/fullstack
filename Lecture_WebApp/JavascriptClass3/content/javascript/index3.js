function arithematicOperations(a, b, callback) {
    callback(a, b)
}


function addition(x, y) {
    console.log(x + y)
}

function subtraction(x, y) {
    console.log(x - y)
}
arithematicOperations(50, 13, subtraction)


arithematicOperations(30, 30, function (x, y) {
    console.log("multiply = " + (x * y))
})

arithematicOperations(30, 15, (x, y) => console.log(x / y));