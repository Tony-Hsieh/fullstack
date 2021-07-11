/*console.log(document.querySelector("#txtFirstNumber").value) */

function addition() {
    var x = parseFloat(document.querySelector("#txtFirstNumber").value)
    var y = parseFloat(document.querySelector("#txtSecondNumber").value)
    // var z = x+y
    if (!isNaN(x) && !isNaN(y)) {
        var z = parseFloat(x) + parseFloat(y);
        document.querySelector("#txtResult").value = z
    }
    
  

}