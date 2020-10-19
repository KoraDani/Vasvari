<?php
$connect = new mysqli('localhost','root','','kosarlabda','3306');
        if ($connect -> errno != 0) {
            die("Hiba! ".$connect -> error);
        }
        if (!$connect -> set_charset("utf8")) {
            echo "Karakterkodólás sikertelen";
        }