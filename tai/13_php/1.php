<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PHP- zajęcia 1</title>
</head>
<body>
    <?php
        $firstName = "Janusz";
        $lastName = "Nowak";
        echo "Imię: $firstName<br>";
        echo "Nazwisko: $lastName<hr>";
        echo 'Text: $firstName $lastName<hr>';

        //heredoc
        echo <<< DATA
            Imię: $firstName<br>
            Nazwisko: $lastName
            <hr>
DATA;
    //echo phpinfo(); //php => 8.2.4

        //nowdoc
        echo <<< 'DATA'
            Imię: $firstName<br>
            Nazwisko: $lastName
            <hr>
DATA;
    ?>
</body>
</html>