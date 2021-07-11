function createLocal() {
    localStorage.setItem("uname", document.querySelector("[type='text']").value);
}
function readLocal() {
    console.log(localStorage.getItem("uname"))
}
function deleteLocal() {
    localStorage.removeItem("uname")

    
}

/*
 *  1 line code takes 10 second
 *  2 line code takes 1 second
 *  3 line code takes 1 second
 *    synchronously = 12 second
 *    
 *    asyschrnously = 10 second
 */