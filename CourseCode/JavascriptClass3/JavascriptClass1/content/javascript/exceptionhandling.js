try {
    //let c = document.querySelector("div").value;
    let person = {
        id: 1,
        name: 'steven',
        age: 28
    };
    if (person.age < 20)
        throw new Error("Under aged")
}
catch (e) {
    console.log(e.message)
}
finally {
    console.log("welcome to javascript")
}
