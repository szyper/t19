<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h3>Dane pobrane z formularza</h3>
    <?php
        //echo "<pre>";
        //print_r($_SERVER);
        //echo "</pre>";

        if (!isset($_SERVER) || $_SERVER["REQUEST_METHOD"] != "POST") {
            //echo "<script>history.back();</script>";
            echo "<h3>Proszę wprowadzić dane do formularza!</h3>";

            $encodeErrorMsg = urlencode("Błąd wprowadzonych danych");
            header("Refresh: 3; url=form.php?error=$encodeErrorMsg");
            exit();
        }

        //pobieranie danych z formularza
        //sposób na zapobieganie atakom typu XSS lub SQL Injection
        //XSS - Cross-Site Scripting, czyli atak na serwis www, który polega na wstrzyknięciu do przeglądarki ofiary fragmentu kodu skryptowego, zwykle JavaScript
        //SQL Injection - to technika ataku komputerowego, która polega na wstrzyknięciu do zapytania SQL fragmentu kodu, który może zmienić jego działanie lub wykonać dodatkowe operacje na bazie danych

        //$name = $_POST["name"];
        $name = filter_input(INPUT_POST, "name", FILTER_SANITIZE_STRING);
        //echo $name;
        $email = filter_input(INPUT_POST, "email", FILTER_SANITIZE_EMAIL);
        $birthday = filter_input(INPUT_POST, "birthday", FILTER_SANITIZE_STRING);

        //echo $birthday;

        //definicja zmiennych do przechowywania błędów
        $name_error = "";
        $email_error = "";
        $birthday_error = "";

        //sprawdzić, czy pole name jest wypełnione i zawiera tylko litery i spacje
        if (empty($name)) {
            $name_error = "Podaj imię";
        }elseif(!preg_match("/^[a-zA-Z ]*$/", $name)){
            $name_error = "Imię może zawierać tylko litery oraz spacje";
        }

        //sprawdzić, czy pole email jest wypełnione i zawiera poprawny adres email
        if (empty($email)) {
            $email_error = "Podaj email";
        }elseif (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
            $email_error = "Podaj poprawny adres email";
        }

        //sprawdzić, czy pole birthday jest wypełnione i zawiera poprawną datę
        if (empty($birthday)) {
            $birthday_error = "Podaj datę urodzenia";
        }elseif (!preg_match("/^\d{4}-\d{1,2}-\d{1,2}$/", $birthday)) {
            $birthday_error = "Podaj datę w formacie RRRR-MM-DD";
        }


        //jeśli wystąpiły jakieś błędy, wyświetl je i przekieruj użytkownika z powrotem do formularza
        if ($name_error || $email_error || $birthday_error) {
            $error_msg = "Błąd wprowadzonych danych:<br>";
            $data["name"] = "";
            $data["email"] = "";
            $data["birthday"] = "";
            //dodanie do zmiennej informacji o błędach w poszczególnych polach
            if ($name_error) {
                $error_msg .= $name_error . "<br>";
            }else{
                $data["name"] = $name; 
            }

            if ($email_error) {
                $error_msg .= $email_error . "<br>";
            }else{
                $data["email"] = $email;
            }

            if ($birthday_error) {
                $error_msg .= $birthday_error . "<br>";
            }else{
                $data["birthday"] = $birthday;
            }

            //echo $error_msg;
            //echo $data["name"],$data["email"],$data["birthday"];
            /*
            foreach ($data as $key => $value) {
                echo "$key: $value<br>";
            }
            */
            echo "<h3>Proszę wprowadzić prawidłowo dane do formularza!</h3>";

            //$encodeErrorMsg = urlencode($error_msg);

            header('Refresh: 3; url=form.php?error=$encodeErrorMsg&name=$data["name"]&email=$data["email"]&birthday=$data["birthday"]');
            //echo "<script>history.back();</script>";
            exit();
        }

    ?>
</body>
</html>