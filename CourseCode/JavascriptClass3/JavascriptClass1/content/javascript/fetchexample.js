let p = fetch("https://jsonplaceholder.typicode.com/posts").then(function (response) {
    return response.json()
}).catch(function (e1) {
    console.log(e1)
})

p.then(function (data) {

    let tbody = document.querySelector("#tblPost tbody");
    tbody.innerHTML = "";
    let length = data.length;
    for (let i = 0; i < length; i++) {
        let tr = `<tr><td>${data[i].id}</td> <td>${data[i].title}</td> <td>${data[i].body}</td> </tr>`
        tbody.innerHTML = tbody.innerHTML + tr
    }


   
}).catch(function (e) {

    console.log(e)
})

//console.log(p)