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
        $veletlen = array();
        for ($i=0; $i < 92; $i++) { 
            array_push($veletlen,random_int(20, 40));
            echo '<p>'.$veletlen[$i].'</p>';
        }
        $min = $veletlen[0];
        $max = $veletlen[0];
        $index = 0;
        $juniusmax= 0;
        $juniusmin = 0;
        for ($i=0; $i < count($veletlen); $i++) { 
            if ($min>$veletlen[$i]) {
                $min=$veletlen[$i];
                $juniusmin =$i;
            }
            if ($max<$veletlen[$i]) {
                $max=$veletlen[$i];
                $juniusmax =$i;
            }
        }
        
        echo '<p>Minimum'.$min.'</p>';
        echo '<p>Maximum'.$max.'</p>';
        if ($juniusmax < 30) {
            echo '<p>Junius min'.($juniusmin+1).'</p>';
            echo '<p>Junius max'.($juniusmax+1).'</p>';
        }else if ($juniusmax< 62) {
            echo '<p>Julius min'.($juniusmin-29).'</p>';
            echo '<p>Julius max'.($juniusmax-29).'</p>';
        }elseif ($juniusmax<92) {
            echo '<p>Augusztus min'.($juniusmin-61).'</p>';
            echo '<p>Augusztus max'.($juniusmax-61).'</p>';
        }
        //átlaghőmérséklet, havi szinten hol van legmagasab és írja ki melyik nap
    ?>
</body>
</html>