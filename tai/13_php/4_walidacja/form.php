<?php
if (isset($_GET["error"])) {
	echo urldecode($_GET["error"]);
}
?>
<form action="walidacja.php" method="post">
	<input type="text" name="name" id="name" placeholder="Podaj imię"><br><br>
	<input type="email" name="email" id="email" placeholder="Podaj email"><br><br>
	<input type="date" name="birthday" id="birthday"> Data urodzenia<br><br>
	<input type="submit" value="Zatwierdź">
</form>

<!--
Imię: Pole jest wymagane. Jeśli zostanie pozostawione puste, wyświetl komunikat “Imię jest wymagane.”
Email: Sprawdź, czy wprowadzony adres email ma prawidłowy format. Jeśli nie, wyświetl komunikat “Nieprawidłowy format adresu email.”
Wiek: Upewnij się, że wiek znajduje się w zakresie od 18 do 120 lat. W przeciwnym razie wyświetl komunikat “Wiek musi być między 18 a 120 lat.”

 -->