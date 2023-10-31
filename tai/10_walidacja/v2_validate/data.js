// console.log("test js");

function areaRectangle(a, b){
    return a * b;
}

function validateInput(input){
    if (isEmpty(input)){
        alert("Proszę wpisać wartość");
        return false;
    }
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
    let length = document.getElementById("length");
    let width = document.getElementById("width");

    if (!validateInput(length) || !validateInput(width)){
        return false;
    }

    

}