<?php
    require_once("connect.php");
    $sql = "SELECT * FROM jatekos";

    $html = "";
    $result = $connect ->query($sql);

    if (!$result) {
        print("Hiba a lekérdezésben");
    }else{
        
        while ($row = $result -> fetch_array()) {
            $html .='<option value="'.$row[0].'">'.$row[1].'</option>';
        }
    }

?>


<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Kosárlabda</title>
    <script src="jquery-3.5.1.min.js"></script>
    <script src="kosar.js"></script>
</head>
<body>
    <select>
        <option value='-1'>Válassz játékost</option>
        <?php
            echo $html;
        ?>
    </select>
</body>
</html>