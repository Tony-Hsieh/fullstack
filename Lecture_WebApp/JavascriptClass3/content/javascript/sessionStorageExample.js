function createSession() {
   let v= document.querySelector("[type='text']").value;
    sessionStorage.setItem("uname",v)
}

function readSession() {
    let v = sessionStorage.getItem("uname");
    console.log(v)
}
function deleteSession() {
    sessionStorage.removeItem("uname")
}