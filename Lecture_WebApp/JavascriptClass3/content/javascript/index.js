// there are two ways to create functions in javascript
// constructor function
// function using literal notation
subtract("50", "10");   
/*constructor notation*/

function printWelcome() {

    console.log("welcome to javascript")
}




printWelcome();

function addNumbers(a, b) {
    console.log(a + b)
}

function subtract(a, b) {
    console.log(a - b)
}




/*literal notation function */

showMenu = function () {
    console.log("Press 1 to add")
    console.log("press 2 to subtract")
}
showMenu()


/**
 * 
 * closure:- nested function:- it will have access of all the variables/parameters/properties of the outer function
 */
function areaOfCircle(radius) {

    function square() {
        return radius * radius;
    }
    console.log(3.14 * square())
}

areaOfCircle(10);

