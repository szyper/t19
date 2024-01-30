<?php
    // if (isset($_GET['newsletter'])) {
    //     echo "ok";
    // }else{
    //     echo "error";
    // }
    if (empty($_GET['firstName']) || empty($_GET['lastName']) || empty($_GET['gender']) || empty($_GET['color']) || empty($_GET['description'] || empty($_GET['birthYear']))) {
        echo "Wypełnij wszystkie pola formularza!";
    }else{
        $firstName = $_GET['firstName'];
        $lastName = $_GET['lastName'];
        $gender = $_GET['gender'];
        $color = $_GET['color'];
        $description = $_GET['description'];
        $birthDate = $_GET['birthDate'];
        if (isset($_GET['newsletter'])) {
            $newsletter = $_GET['newsletter'];
            if ($newsletter == "yes") {
                echo "<p>Dziękujemy za zapisanie się do newslettera</p>";
            }
        }
        else{
            echo "<p>Możesz zapisać się do newslettera</p>";
        }
        echo <<< SHOWDATA
            <h1>Witaj, $firstName $lastName</h1>
            <p>Płeć: $gender</p>
            <p>Ulubiony kolor: $color</p>
            <p>Opis: $description</p>
SHOWDATA;
        //echo checkAge(2020);
        $isAdult = checkAge2($birthDate);

        if ($isAdult) {
            echo "<p>Jesteś pełnoletni</p>";
        }else{
            echo "<p>Nie jesteś pełnoletni</p>";
        }
        echo "<style>body {background-color: $color;}</style>"; 

        //echo checkAge2($birthDate);

       
    }

    function checkAge1($birthDate){
        $currentDate = date("Y-m-d");
        //$age = $currentYear - $birthYear;

        $age = strtotime($currentDate) - strtotime($birthDate);
        $age = floor($age / (60*60*24*365.25));

        if ($age >= 18) {
            return true;
        }else{
            return false;
        }
        //return $currentYear;
    }

    function checkAge2($birthDate){
        $currentDate = date("Y-m-d");
        //$birthDate = date("Y-m-d", strtotime($birthDate));
        $diff = date_diff(date_create($birthDate), date_create($currentDate));
        $age = $diff->format("%y");

        if ($age >= 18) {
            return true;
        }else{
            return false;
        }
        // return $age;
    }
?>


<!-- Utwórz plik o nazwie 3_data.php i otwórz go w edytorze kodu.
W pliku 3_data.php, pobierz dane z formularza HTML za pomocą tablicy globalnej $_GET i zapisz je w zmiennych.
Sprawdź, czy wszystkie pola formularza zostały wypełnione przez użytkownika. Jeśli nie, wyświetl komunikat o błędzie.
Jeśli wszystkie pola formularza zostały wypełnione, wyświetl dane na ekranie w formacie HTML, 
używając znaczników <h1>, <p> i <style>.
Zmień kolor tła strony na kolor wybrany przez użytkownika, używając właściwości CSS background-color. -->


<!-- Dodaj do formularza HTML pole typu number, o nazwie birthYear, z etykietą Rok urodzenia i atrybutem required.
W pliku 3_data.php, pobierz wartość pola birthYear z tablicy $_GET i zapisz ją w zmiennej.
Napisz funkcję o nazwie checkAge, która przyjmuje jako argument rok urodzenia i zwraca wartość logiczną true, jeśli użytkownik jest pełnoletni, lub false, jeśli nie jest.
Wywołaj funkcję checkAge dla zmiennej z rokiem urodzenia i zapisz wynik w innej zmiennej.
Wyświetl na ekranie informację o wieku użytkownika, używając instrukcji warunkowej if…else i znacznika <p>. -->

<!-- Dodaj do formularza HTML pole typu checkbox, o nazwie newsletter, z etykietą.
Zapisz się do newslettera i wartością yes.
W pliku 3_data.php, pobierz wartość pola newsletter z tablicy $_GET i zapisz ją w zmiennej.
Sprawdź, czy użytkownik zaznaczył pole newsletter. 
Jeśli tak, wyświetl na ekranie komunikat Dziękujemy za zapisanie się do newslettera!
Jeśli nie, wyświetl komunikat Możesz się zapisać do newslettera w każdej chwili.. -->