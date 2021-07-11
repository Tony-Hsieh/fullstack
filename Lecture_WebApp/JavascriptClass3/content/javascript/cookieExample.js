function createCookie() {
    let v = document.querySelector("[type='text']").value;
    document.cookie = "uname=" + btoa( v);
}

function readCookie() {
    let v = document.cookie.split('=');
    console.log(atob(v[1]))
}