<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
    <style>
        p{
            font-style: italic;
            text-decoration: underline;
        }
    </style>
</head>
<body>
<?php
    for ($i=1; $i < 11; $i++) { 
        echo "<p>".$i."</p>";
    }
    $i = 1;
    do {
        echo $i."&nbsp&nbsp&nbsp";
        $i++; 
    } while ($i < 11);
    $i = 1;
    while ($i < 11) {
        echo"<button>".$i.". &#128465</button>";
        $i++;
    }
    $napok = array("hétfő","kedd","szerda","csütörtök","péntek","szombat","vasárnap");
    foreach ($napok as $nap) {
        echo $nap . ", ";
    }
?>
</body>
</html>
