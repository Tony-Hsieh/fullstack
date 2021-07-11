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

let btnSub = document.querySelector("#btnSubtract");
btnSub.addEventListener("click", function () {
    var x = parseFloat(document.querySelector("#txtFirstNumber").value)
    var y = parseFloat(document.querySelector("#txtSecondNumber").value)
    // var z = x+y
    if (!isNaN(x) && !isNaN(y)) {
        var z = parseFloat(x) - parseFloat(y);
        document.querySelector("#txtResult").value = z
    }
})

function showCountry() {
    let x = document.querySelector("#ddlCountry").value;
    document.querySelector("#countrymsg").innerHTML = "<b>selected value = " + x+"</b>";
}

function showHidePanel() {
    
    let x = document.querySelector("#ddlShowHide").value;
    if (x > 0) {
        let p = document.querySelector("#arth");
        
        if(x==2)
            p.setAttribute("style", "display:none");
        if (x == 1)
            p.setAttribute("style", "display:block");
    }
}