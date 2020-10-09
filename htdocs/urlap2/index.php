<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Űrlap</title>
</head>
<body>
<form action="#" method="post">
    <input type="email" name="email" placeholder="Email" action="#" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,}$"><br>
    <input type="password" name="pwd" placeholder="Jelszó" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{7,}" required><br>
    <input type="submit" value="Submit">
</form>
    
</body>
</html>