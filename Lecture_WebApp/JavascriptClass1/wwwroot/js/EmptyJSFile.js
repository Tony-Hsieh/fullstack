
/* constructor notation*/

function printWelcome() {
    console.log("welcom to js")
}

var p = new printWelcome();
console.log(p)

printWelcome();
function addNumbers(a, b) {
    console.log(a+b)
}

addNUmbers(20, 10);

/* literal notation function*/

showMenu = function () {
    console.log("press 1 to add")
    console.log("press 2 to subtract")
}
showMenu()

/*difference: literal vs constructor
 * constructor can self hoisting
 *      */


/* closure: - nested function: it will have access of all the variables/parameters/properties of the outer function*/
function areaOfCircle(radius) {
    function square() {
        return radius * radius;
    }
    console.log(3.14*square())

}
areaOfCircle(10);
var a  = new areaOfCircle(20);
