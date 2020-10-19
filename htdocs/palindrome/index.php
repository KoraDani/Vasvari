<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form action="#" methode="get">
        <input type="text" name="palindrom">
        <input type="submit" name="submit">
    </form>
    <?php

    if (isset($_GET['submit'])) {
        echo '<p>'.palindrome($_GET['palindrom']).'</p>';
    }
    function palindrome($asd)
    {
        $asd = strtolower($asd);
        $asd= str_replace(" ","", $asd);
        $ekezet = array("á","é","ó","ő","ü","ö","ű","ú","í");
        $nemekezet= array("a","e","o","u","i");
        $irasjel=array(".","!","?");
        $asd = str_replace($irasjel,"",$asd);
        $asd = str_replace($ekezet,$nemekezet,$asd);
        if ($asd == strrev($asd))
            return "Palindrom";
        else
            return "Nem palindrom";
    }
    ?>
</body>

</html>