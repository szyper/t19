<?php
    if (isset($_GET["error"])) {
        //echo urldecode($_GET["error"]);
    }
?>
<form action="walidacja.php" method="post">
    <input type="text" name="name" id="name" placeholder="Podaj imię"><br><br>
    <input type="email" name="email" id="email" placeholder="Podaj email"><br><br>
    <input type="date" name="birthday" id="birthday"> Data urodzenia<br><br>
    <input type="submit" value="Zatwierdź">
</form>