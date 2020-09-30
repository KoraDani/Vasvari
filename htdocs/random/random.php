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
        $t = array();
        for ($i=0; $i < 100; $i++) { 
            array_push($t,random_int(1,100));
        }
        echo '<pre>';
        print_r($t);

        for ($i=1; $i < 101; $i++) { 
            if(!(in_array($i, $t))){
                echo $i.'; ';
            }
        }
        $kisebb = 0;
        $nagyobb = 0;
        $paros = 0;
        $paratlan = 0;
        for ($i=0; $i < 100; $i++) { 
            if ($t[$i] < 50) {
                $kisebb++;
            }if ($t[$i] > 50) {
                $nagyobb++;
            }
            if ($t[$i] % 2 == 0) {
                $paros++;
            }
            else {
                $paratlan++;
            }
        }
        if ($kisebb < 50) {
            echo '<p>50-nél kisebből van több</p>';
        }else {
            echo '<p>50-nél nagyobb több van</p>';
        }
        echo '<p>'.$paros.'</p>';
        echo '<p>'.$paratlan.'</p>';

        $nulla = 0;
        $ezer = array();
        for ($i=0; $i < 100; $i++) { 
            array_push($ezer,random_int(-500,500));
            if ($ezer[$i] == 0) {
                $nulla++;
            }
        }

        echo '<p>'.$nulla.'</p>';
        echo '<p>Összege: '.array_sum($ezer).'</p>';
    ?>
</body>
</html>