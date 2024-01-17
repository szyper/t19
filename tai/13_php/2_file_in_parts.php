<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h4>Początek</h4>
    <!-- dodanie zawartości pliku data.php -->
    <?php
        //include("./data.php");
        //include_once("./data.php");
        require_once("./data.php");
        require("./data.php");
        require_once("./data.php");
        include("./data.php");

        require_once("./function.php");
        show();
    ?>
    <h4>Koniec</h4>
</body>
</html>