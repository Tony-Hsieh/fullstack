let countries = new Array(4)
countries[0] = "USA"
countries[1] = "Canada"
countries[2] = "Germany"
countries[3] = "Mexico"
countries.push("Italy")
console.log(countries)

let companies = new Array("IBM", "Microsoft", "Facebook", "Yahoo", "Google")
console.log(companies)



let employees = ["Peter", "John", "Maria", "Olivia", "Smith"];
console.log(employees)

let departments = []
departments.push("IT")
departments.push("HR")
departments.push("Manufacturing")
departments.push("Sales")
departments.push("Accounts")

departments.unshift("Networking")


departments.sort();
let longdept = departments.filter((v, i, arr) => v.length >= 5);
console.log(longdept)

//departments.pop()
//departments.shift();



console.log(departments)



let numbers = [1, 55, 33, 11, 2, 44, 4, 5, 3, 22]

//numbers.sort(sortNumbers);


//function sortNumbers(a, b) {
//    return b - a;
//}


numbers.sort((a, b) => a - b)

console.log(numbers)


let result = numbers.filter((v, i, arr) => v % 2 == 0);
console.log(result)




let duplicate = ["IBM","IBM","Microsoft", "Yahoo","Facebook", "IBM", "AMD", "Twitter", "Yahoo", "AMD"]
console.log(duplicate)

let unique = duplicate.filter((v, i, arr) => arr.indexOf(v) == i)
console.log(unique)