<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Projekty</title>
  <link rel="stylesheet" href="./styles.css">
  <script src="./script.js"></script>
</head>
<body>
<?php
//sprawdzenie, czy w URL są błędy i wyświetlenie ich
if (isset($_GET['errors'])) {
	// echo '<pre>';
	// 	print_r($_GET['errors']);
	// echo '</pre>';

	$errors = $_GET['errors'];
	echo '<ul>';
	// foreach ($errors as $error) {
	// 	echo "<li>$error</li>";
	// }
	foreach ($errors as $key => $error) {
		if ($key == 'errors') {
			echo "<li>$key: $error</li>";
		}
	}
	echo '</ul>';
}
?>
<h2>Zgłoś pomysł na projekt</h2>
<form action="./submit_form.php" method="post" id="projectForm">
  Nazwa projektu: <input type="text" name="projectName" id="projectName"><br>
  Opis projektu:<br>
  <textarea name="projectDescription" cols="40" rows="5"></textarea><br>
  <select name="projectCategory">
    <option value="technology">Technologia</option>
    <option value="education">Edukacja</option>
    <option value="entertainment">Rozrywka</option>
  </select><br>
  Adres e-mail: <input type="text" name="email"><br>
  Potwierdź adres e-mail: <input type="text" name="confirmEmail"><br>
  <input type="submit" value="Wyślij">
</form>
</body>
</html>
