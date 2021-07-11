/*
 *  literal notation is singleton in nature means only one object can exist
 * 
 */

department = {
    id: 1,
    name: "IT",
    location: "Sterling"

}


console.log(department.id + " " + department.name)


function employee() {
    this.id = 0
    this.name = ""
    this.salary = 0
}




let e1 = new employee();
e1.id = 1
e1.name = "Smith"
e1.salary = 7000
e1.department = department;

console.log(e1.id + " " + e1.name)

let e2 = new employee();
e2.address = "demo street, demo apartment demo city";
e2.department = "IT"




/*
 * exception handling
 * class
 * promise
 */