<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>PHP tömbök</title>
    <style>
        table, td{
            border: 1px solid black;
            border-collapse: collapse;
        }
    </style>
</head>
<body>
    <?php
        $autok = array("Volvo","Suzuki","Opel","Trabant","Kia");
        array_push($autok,"Honda","BMW"); //2 elemet fűzik a végéhez
        array_shift($autok); // 1 elemet törlök az elejéről
        array_unshift($autok,"Ford"); //1 elem az elejére
        echo '<table>';
        for ($i=0; $i < count($autok); $i++) { 
            echo '<tr> <td>'.($i+1).'.</td> <td>'.$autok[$i].'</td> </tr>';
        }
        echo '</table>';
    ?>
</body>
</html>