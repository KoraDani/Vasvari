<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Kosárlabda</title>
</head>
<body>
    <?php
        //include();
        //require();
        require_once('connect.php');
        
        $sql = "SELECT * FROM jatekos";
        //var_dump($connect);

        $result = $connect -> query($sql);
        //var_dump($result);
        if ($result) {
            echo "Tábla tartalma";
            echo "<table>";
            while ($row =$result -> fetch_array()) {
                echo "<tr>";
                echo "<td>{$row[0]}</td>";
                echo "<td><a href='jegyzokonyv.php?mez={$row[0]}'> {$row[1]}</a></td>";
                echo "<td>{$row[2]}</td>";
                echo "<td>{$row[3]}</td>";
                echo "</tr>";
            }
            echo "</table>";
        }else {
            echo "Hiba a lekérdezésben";
        }
        $connect -> close();
    ?>
</body>
</html>