<!DOCTYPE html>
<html lang="en">
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
    ?>
</body>
</html>