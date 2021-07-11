console.log(document)


console.log(document.querySelector("#txtFirstNumber").value)


console.log(document.querySelector("#txtFirstNumber").getAttribute("value"))

function addition() {
    var x = document.querySelector("#txtFirstNumber").value
    var y = document.querySelector("#txtSecondNumber").value
    if (x != Nan && y != Nan) {
        //var z = x + y;
        var z = parseFloat(x) + parseFloat(y);
        document.querySelector("#txtResult").value = z
    }
   

}