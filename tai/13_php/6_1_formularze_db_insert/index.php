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

  //echo $_GET['errors']['errors'];
  $errors = explode(', ', $_GET['errors']['errors']);
  //var_dump($errors);
  echo '<ul>';
    foreach ($errors as $error) {
      echo "<li>$error</li>";
    }
  echo '</ul>';
}
?>
<h2>Zgłoś pomysł na projekt</h2>
<form action="./submit_form.php" method="post" id="projectForm">
  Nazwa projektu: <input type="text" name="projectName" id="projectName" value="<?php echo !empty($_GET['errors']['projectName']) ? $_GET['errors']['projectName'] : '' ?>"><br>
  Opis projektu:<br>
  <textarea name="projectDescription" cols="40" rows="5"><?php echo !empty($_GET['errors']['projectDescription']) ? $_GET['errors']['projectDescription'] : '' ?></textarea><br>
  
  <select name="projectCategory">
    
    <?php
      $projectCategories = array(
        'technology' => 'Technologia',
        'education' => 'Edukacja',
        'entertainment' => 'Rozrywka'
      );

      $selectedCategory = $_GET['errors']['projectCategory'];

      foreach ($projectCategories as $projectCategory => $categoryName) {
        $selected = $selectedCategory == $projectCategory ? 'selected' : '';
          echo "<option value=\"$projectCategory\" $selected>$categoryName</option>";
      }
    ?>

  </select><br>


  Adres e-mail: <input type="text" name="email" value="<?php echo !empty($_GET['errors']['email']) ? $_GET['errors']['email'] : '' ?>"><br>
  Potwierdź adres e-mail: <input type="text" name="confirmEmail" value="<?php echo !empty($_GET['errors']['confirmEmail']) ? $_GET['errors']['confirmEmail'] : '' ?>"><br>
  <input type="submit" value="Wyślij">
</form>
</body>
</html>
