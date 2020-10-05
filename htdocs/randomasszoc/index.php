<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $szam;
        $a= array();
        for ($i=100; $i < 110; $i++) { 
            $szam = rand(1,100);
           $a += array(strval($i) => $szam);
        }
        echo '<pre>';
        print_r($a);
        echo  '</pre>';
    ?>
</body>
</html>