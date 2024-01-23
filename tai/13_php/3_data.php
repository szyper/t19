<!doctype html>
<html lang="pl">
<head>
  <meta charset="UTF-8">
  <meta name="viewport"
        content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>Użytkownik</title>
</head>
<body>
<h3>Dane użytkownika</h3>
<?php
//	if (!empty($_GET)){
//		echo $_GET["przycisk"]."<br>";
//	}else{
//		echo "nie mamy pola do wyswietlenia";
//	}

//isset (istneje) czy !empty (jest wypełnione)
if (!empty($_GET['firstName']) && !empty($_GET['lastName']) && !empty($_GET['gender']) && !empty($_GET['color'])){
	echo "Imię i nazwisko: ".$_GET['firstName']." ".$_GET['lastName'].", ";
  switch ($_GET['gender']){
    case "m":
      $gender = "mężczyzna";
      break;
    case "k":
      $gender = "kobieta";
      break;
  }
  echo "płeć: ".$gender."<br>";
  echo "<p>Ulubiony kolor: "."<span style='background-color: $_GET[color]'>".$_GET['color']."</span></p>";
  if (!empty($_GET['description'])){
    echo<<<DATA
Opis użytkownika: $_GET[description]
DATA;

  }
}else{
  echo "<p>Wypełnij wszystkie pola!</p>";
  echo "<script>setTimeout(function(){history.back();}, 5000);</script>";
}


?>
</body>
</html>