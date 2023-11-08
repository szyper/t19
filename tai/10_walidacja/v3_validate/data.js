// console.log("test js");

function areaRectangle(a, b){
    return a * b;
}

function perimeterRectangle(a, b){
    return (a + b) * 2;
}

function validateInput(input){
    if (isEmpty(input)){
        alert("Proszę wpisać wartość");
        return false;
    }
    return true;
}

function isEmpty(input){
    let value = input.value.trim();
    if (value === ""){
        return true;
    }else{
        return false;
    }
}

function validate(){
    console.log("test");
    let length = document.getElementById("length");
    let width = document.getElementById("width");

    if (!validateInput(length) || !validateInput(width)){
        return false;
    }

    let area = areaRectangle(length.value, width.value);
    let perimeter = perimeterRectangle(Number(length.value), Number(width.value));

    let output = document.getElementById("output");
    output.innerHTML = "Pole prostokąta wynosi:" + area + ", obwód prostokąta wynosi: " + perimeter;

}