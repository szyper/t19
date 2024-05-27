<?php
//echo $_SERVER['REQUEST_METHOD']
echo '<pre>';
//print_r($_SERVER);
//print_r($_POST);
echo '</pre>';
if ($_SERVER['REQUEST_METHOD'] == 'POST'){
	$projectName = htmlspecialchars(trim($_POST['projectName']));
	$projectDescription = htmlspecialchars(trim($_POST['projectDescription']));
	$projectCategory = htmlspecialchars(trim($_POST['projectCategory']));
	$email = htmlspecialchars(trim($_POST['email']));
	$confirmEmail = htmlspecialchars(trim($_POST['confirmEmail']));

	$errors = array();

	if (empty($projectName)) {
		$errors[] = 'Nazwa projektu jest wymagana';
	} else if (strlen($projectName) < 3 || strlen($projectName) > 50){
		$errors[] = 'Nazwa projektu musi zawierać od 3 do 50 znaków';
	}

	if (empty($projectDescription)) {
		$errors[] = 'Opis projektu jest wymagany';
	} else if (strlen($projectDescription) < 10 || strlen($projectDescription) > 1000){
		$errors[] = 'Opis projektu musi zawierać od 10 do 1000 znaków';
	}

	if (!in_array($projectCategory, ['technology', 'education', 'entertainment'])) {
		$errors[] = 'Wybierz poprawną kategorię projektu';
	}

	if (empty($email)) {
		$errors[] = 'Adres e-mail jest wymagany';
	} else if (!filter_var($email, FILTER_VALIDATE_EMAIL)){
		$errors[] = 'Nieprawidłowy format adresu e-mail';
	}

	if (empty($confirmEmail)) {
		$errors[] = 'Potwierdzenie adresu e-mail jest wymagane';
	} else if (!filter_var($email, FILTER_VALIDATE_EMAIL)){
		$errors[] = 'Nieprawidłowy format potwierdzenia adresu e-mail';
	}

	if ($email != $confirmEmail) {
		$errors[] = 'Adresy e-mail nie są identyczne';
	}

//przygotowanie danych do przekazania
// $errors = implode(', ', $errors);
// echo $errors;

	$dataToPass = array(
		'errors' => implode(', ', $errors), //błędy jako ciąg znaków
		'projectName' => $projectName,
		'projectDescription' => $projectDescription,
		'projectCategory' => $projectCategory,
		'email' => $email,
		'confirmEmail' => $confirmEmail
	);


	if (!empty($errors)) {
		// echo '<pre>';
		// 	print_r($errors);
		// echo '</pre>';

		//przekonwertowanie tablicy błędów na ciąg zapytania URL
		$queryString = http_build_query(array('errors' => $dataToPass));

		//przekierowanie do index.php z błędami
		header("Location: index.php?$queryString");
		exit();
	} else {
		echo <<< DATA
			Nazwa projektu: $projectName<br>
			Opis projektu: $projectDescription<br>
			Kategoria projektu: $projectCategory<br>
			E-mail: $email<br>
DATA;

		//konfiguracja bazy danych
		require_once './connect.php';

		//przygotowanie zapytania SQL
		$stmt = $mysqli->prepare("INSERT INTO `project` (`projectName`, `projectDescription`, `email`) VALUES (?,?,?)");

		//bezpieczne przypisanie wartości i wykonanie zapytania SQL
		$stmt->bind_param('sss', $projectName, $projectDescription, $email);
		$stmt->execute();

		//sprawdzenie, czy zapytanie się powiodło
		if ($stmt->affected_rows == 1) {
            echo 'Projekt został dodany';
        } else {
            echo 'Projekt nie został dodany';
        }

		//zamknięcie połączenia z bazą danych
		$stmt->close();
        $mysqli->close();
	}

}


?>