<?php
//echo $_SERVER['REQUEST_METHOD']
echo '<pre>';
//print_r($_SERVER);
//print_r($_POST);
echo '</pre>';
if ($_SERVER['REQUEST_METHOD'] == 'POST'){
	$projectName = $_POST['projectName'];
	$projectDescription = $_POST['projectDescription'];
	$projectCategory = $_POST['projectCategory'];
	$email = $_POST['email'];
	$confirmEmail = $_POST['confirmEmail'];

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

	} else {
		echo <<< DATA
			Nazwa projektu: $projectName<br>
			Opis projektu: $projectDescription<br>
			Kategoria projektu: $projectCategory<br>
			E-mail: $email<br>
DATA;
	}
}


?>