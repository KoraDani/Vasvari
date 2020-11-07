<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Tutipicitörpék</title>
    <!--<style>
        table, tr, td{
        border-collapse: collapse;
        border: 100px solid #FF006C;
        color:#FCFF00;
        background-color:#A266D9;
        }-->
    </style>
</head>
<body>
<?php
    require_once("connect.php");
    $lek = "SELECT DISTINCT klan FROM torpek";
    $result = $connect -> query($lek);
    echo $result -> num_rows."db<br>";

    $sql = "SELECT * FROM torpek";
    $result = $connect -> query($sql);
    echo $result -> num_rows."db torpék száma<br>";



    echo "Tábla tartalma";
    echo "<table>";
    while ($row =$result -> fetch_array()) {
        echo "<tr>";
        echo "<td>{$row[0]}</td>";
        echo "<td>{$row[1]}</td>";
        echo "<td>{$row[2]}</td>";
        echo "<td>{$row[3]}</td>";
        echo "<td>{$row[4]}</td>";
        echo "<td>{$row[5]}</td>";
        echo "</tr>";
    }
    echo "</table>";

?>

</body>
</html>