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
        if ($asd == strrev($asd))
            return "Palindrom";
        else
            return "Nem palindrom";
    }
    ?>
</body>

</html>