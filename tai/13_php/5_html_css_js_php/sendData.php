<?php
  //odbieranie danych z formularza
	$name = $_POST["name"];
	$email = $_POST["email"];
	$message = $_POST["message"];
	$gender = $_POST["gender"];
	$hobbies = $_POST["hobbies"];
	$color = $_POST["color"];

	//sanityzacja danych - usuwamy niepożądane znaki
	$name = filter_var($name, FILTER_SANITIZE_STRING);
	$email = filter_var($email, FILTER_SANITIZE_EMAIL);
	$message = filter_var($message, FILTER_SANITIZE_STRING);
	$gender = filter_var($gender, FILTER_SANITIZE_STRING);
	$hobbies = filter_var($hobbies, FILTER_SANITIZE_STRING);
	$color = filter_var($color, FILTER_SANITIZE_STRING);

	//walidacja danych - sprawdzamy czy dane spełniają kryteria
	//tworzymy tablicę z flagami błędów
	$errors = array();

	//sprawdzamy czy imię jest niepuste i ma co najmniej 2 znaki
	if (empty($name) || strlen($name) < 2) {
		$errors["name"] = "Proszę podać poprawne imię";
	}

	//sprawdzamy czy email jest niepusty i ma poprawny format
	if (empty($email) || !filter_var($email, FILTER_VALIDATE_EMAIL)) {
		$errors["email"] = "Proszę podać poprawny email";
	}

	//sprawdzamy czy wiadomość jest niepusta i ma conajmniej 10 znaków
	if (empty($message) || strlen($message) < 10) {
		$errors["message"] = "Proszę podać poprawną wiadomość";
	}

	//sprawdzamy czy płeć jest niepusta i należy do jednej z trzech opcji
	if (empty($gender) || !in_array($gender, array("Mężczyzna", "Kobieta", "Inna"))) {
		$errors["gender"] = "Proszę wybrać poprawną płeć";
	}

	//sprawdzamy czy hobby jest niepuste i jest tablicą
	//if (empty($hobbies) || !is_array($hobbies)) {
		if (empty($hobbies)) {
		$errors["hobbies"] = "Proszę wybrać co najmniej jedno hobby";
	}

	//sprawdzamy czy kolor jest niepusty i ma poprawny format heksadecymalny
	if (empty($color) || !preg_match("/^#[0-9a-fA-F]{6}$/", $color)) {
		$errors["color"] = "Proszę wybrać poprawny kolor";
	}

	if (empty($errors)) {
		echo <<< DATA
			Dziękujemy za prawidłowo wypełniony formularz<br>
DATA;
	}else{
		foreach ($errors as $key => $value) {
			echo "$key: $value<br>";
		}
	}
?>