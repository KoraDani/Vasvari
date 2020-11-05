<?php
    $connect = new mysqli("localhost","root","","torpetarna","3306");

    if ($connect -> connect_errno > 0) {
        die("Hiba".$connect -> connect_errno);
    }

    if (!($connect -> set_charset("utf8"))) {
        print("Hiba a karakter kódolás beállítása közben!");
    }