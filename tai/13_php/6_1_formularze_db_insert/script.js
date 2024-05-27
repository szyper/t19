// Prosta walidacja formularza przed wysłaniem
document.getElementById('projectForm').onsubmit = function() {
    // Pobranie wartości z formularza
    var projectName = document.forms["projectForm"]["projectName"].value;
    var projectDescription = document.forms["projectForm"]["projectDescription"].value;
    var email = document.forms["projectForm"]["email"].value;
    var confirmEmail = document.forms["projectForm"]["confirmEmail"].value;
    var projectDate = document.forms["projectForm"]["projectDate"].value;

    // Sprawdzenie, czy nazwa projektu została wprowadzona
    if (!projectName) {
        alert("Nazwa projektu jest wymagana.");
        return false;
    }

    // Sprawdzenie, czy opis projektu został wprowadzony
    if (!projectDescription) {
        alert("Opis projektu jest wymagany.");
        return false;
    }

    // Walidacja adresu e-mail
    if (!email) {
        alert("Adres e-mail jest wymagany.");
        return false;
    } else if (email !== confirmEmail) {
        alert("Adresy e-mail nie są identyczne.");
        return false;
    } else {
        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/; // Prosty regex dla adresu e-mail
        if (!emailRegex.test(email)) {
            alert("Nieprawidłowy format adresu e-mail.");
            return false;
        }
    }

    // Walidacja daty projektu
    if (!projectDate) {
        alert("Data projektu jest wymagana.");
        return false;
    } else {
        var currentDate = new Date();
        var inputDate = new Date(projectDate);
        if (inputDate > currentDate) {
            alert("Data projektu nie może być z przyszłości.");
            return false;
        }
    }

    // Jeśli wszystkie walidacje przebiegną pomyślnie, formularz zostanie wysłany
    return true;
};
