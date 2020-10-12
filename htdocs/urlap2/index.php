<!DOCTYPE html>
<html lang="hu">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Űrlap</title>
</head>

<body>
    <form action="#" method="get">
        <input type="email" name="email1" placeholder="Email" action="#" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$"><br>
        <input type="password" name="pwd" placeholder="Jelszó" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{7,}" required><br>
        <input type="submit" value="Submit">
    </form>
    <?php
    if (array_key_exists('submit',$_POST)) {
        validateEMAIL($_POST['email']);
        jelszo($_POST["pwd"]);
    }
    function jelszo($password){
        $uppercase = preg_match('@[A-Z]@',$password);
        $lowercase = preg_match('@[a-z]@',$password);
        $number = preg_match('@[0-9]@',$password);
        $length = preg_match('@^.{7,10}$@',$password);
        if (!($uppercase || $lowercase || $number || $length)) {
            echo "Nem megfelelő jelszó";
        }
    }
    function validateEMAIL($EMAiL){
        if (filter_var($EMAiL, FILTER_VALIDATE_EMAIL)) {
            echo "Valós email";
        }
        else {
            echo "Nem valós email";
        }
    }
    ?>
</body>

</html>