<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Urlap</title>
</head>
<body>

    <form action="#" method="get">
        <input type="text" name="user" placeholder="Felhasználónév"><br>
        <input type="password" name="pwd" placeholder="Jelszó"><br>
        <label for="fiu">Fiú</label>
        <input type="radio" name="gender" value="fiu" id="fiu"><br>
        <label for="lany">Lány</label>
        <input type="radio" name="gender" value="lany" id="lany"><br>
        <input type="number" name="zipcode" placeholder="Irányítószám" min="1000" max="9999"><br>
        <input type="email" name="email" placeholder="Email"><br>
        <input type="submit" name="submit" value="Olvas">
    </form>
    <?php
        if (isset($_GET['submit'])) {
            //Elküldték az űrlapot feldolgozásra
            echo "Olvas...";
            var_dump($_GET);
           // echo $_GET[''];
        }
    ?>
</body>
</html>