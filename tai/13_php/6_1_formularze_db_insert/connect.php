<?php
    //kofiguracja połączenia z bazą danych
    $host = 'localhost';
    $db = 't19';
    $user = 'root';
    $pass = '';

    //nazwiązanie połączenia z bazą danych
    $mysqli = new mysqli($host, $user, $pass, $db);

    //sprawdzenie połączenia z bazą danych
    if ($mysqli->connect_errno) {
        die('Błąd połączenia z bazą danych: '. $mysqli->connect_error);
    }

?>