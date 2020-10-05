<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
<?php

    $t = array("Karina" => 18, "István" =>20, "Mária" =>31);
    var_dump($t);
    echo $t['István'];

    foreach ($t as $elem) {
        echo '<p>'.$elem.'</p>';
    }
    $szamok = [5,20,31,40];
    foreach ($szamok as $sz) {
        echo '<p>'.$sz.'</p>';
    }

    echo '<p>'.$szamok['1'].'</p>';
    $key = array_keys($t);
    foreach ($key as $k) {
        echo '<p>'.$k.'</p>';
    }
    $valami1 = current($t);
    echo '<p>'.$valami1.'</p>';
    $valami1 = next($t);
    echo '<p>'.$valami1.'</p>';

?>
    
</body>
</html>