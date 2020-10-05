<!DOCTYPE html>
<html lang="hu">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <?php
    //Azon négyjegyű számokat jelenítsük meg, melyek tükörszónak tekinthetőek!
    echo '<ul>';
    for ($i = 1000; $i < 10000; $i++) {
        $str = strval($i);
        if ($str == strrev($str)) {
            echo '<li>' . $str . '</li>';
        }
    }
    echo '</ul>';

    //Géza kék az ég! Palindrome-e?

    //$mondat = 'Géza kék az ég!';

    $str = "gezakekazeg";
    $str = strtolower($str);

    $strArray = array();
    $strArray = str_split($str);

    $len = sizeof($strArray);
    $reverseStr = array();

    for ($i = $len - 1; $i >= 0; $i--) {
        $reverseStr[] .= $strArray[$i];
    }
    if ($strArray == $reverseStr) {
        echo "$str is a palindrome";
    } else {
        echo "$str is not a palindrome";
    }
    ?>
</body>

</html>