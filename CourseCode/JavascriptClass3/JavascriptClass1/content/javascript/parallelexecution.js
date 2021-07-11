////function demo() {
////    setTimeout(function () {
////        console.log("line 1")
////    }, 3000)

////    console.log("line 2")
////    console.log("line 3")
////}
////demo()


//let p = new Promise(function (resolve, reject) {

//    //resolve("this promise is resolved successfully")
//    resolve("some error has occured in API")
//})

//p.then(function (data) {
//    document.querySelector("#result").innerText = data;

//}).catch(function (e) {
//    console.log(e)

//})



let p = new Promise(function (resolve, reject) {
    resolve(2);
})
p.then((d1) => {
    console.log(d1)
    return d1 * 2
}).then((d2)=> console.log(d2))


//p.then(function (d1) {
//    console.log(d1)
//    return d1 * 2;
//})

//p.then(function (d2) {
//    console.log(d2)
//    return d2 * 2;
//})
//p.then(function (d3) {
//    console.log(d3)
//})