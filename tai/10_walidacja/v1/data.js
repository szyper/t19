// console.log("test js");

function areaRectangle(a, b){
    return a * b;
}



function getData(){
    // console.log('funkcja getData');
    let length = document.getElementById("length").value;
    let width = document.getElementById("width").value;
    //console.log(length + " " + width);

    if (isNaN(length) || isNaN(width)){
        alert("Błędne dane. Podaj liczby rzeczywiste.")
    }else{
        //let area = length * width;
        //console.log(`Pole prostokąta wynosi: ${length * width}`);
        //console.log(`Pole prostokąta o bokach ${length} oraz ${width} wynosi: ${areaRectangle(length, width)}`);

        document.getElementById("output").innerHTML = "Pole prostokąta wynosi: " + areaRectangle(length, width); 
    }

    

}