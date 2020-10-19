<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Jegyzőkönyv</title>
    <style>
        table {
  border-collapse: collapse;
}

table, td, th {
  border: 2px solid black;
}
    </style>
</head>
<body>
    <?php
        require_once("connect.php");

        if (!empty($_GET['mez'])) {
            $mez = $_GET['mez'];
            $sql = "SELECT * FROM jegyzokonyv WHERE mez =".$mez;
            //echo $sql;
            $result = $connect -> query($sql);
            echo "Tábla tartalma";
            echo "<table>";
            while ($row =$result -> fetch_array()) {
                echo "<tr>";
                echo "<td>{$row[0]}</td>";
                echo "<td>{$row[1]}</a></td>";
                echo "<td>{$row[2]}</td>";
                echo "<td>{$row[3]}</td>";
                echo "</tr>";
            }
            echo "</table>";
        }
        else {
            echo "Hiba a lekérdezésben";
        }
        $connect -> close();
    ?>
</body>
</html>