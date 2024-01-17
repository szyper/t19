<?php
    echo "Plik: ".__FILE__.'<br>'; //Plik: C:\xampp\htdocs\php\city.php
    echo 'Nazwa pliku: '.basename(__FILE__).'<br>'; //Nazwa pliku: city.php
    echo 'Nazwa pliku bez rozszerzenia: '.pathinfo(__FILE__, PATHINFO_FILENAME); //city
?>