<!DOCTYPE html>
<!--
Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
Click nbfs://nbhost/SystemFileSystem/Templates/Scripting/EmptyPHPWebPage.php to edit this template
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
    <?php
        $alder = 17;
           if ($alder > 17) {
               echo "Du har stemmeret.";
           } elseif ($alder == 17) {
               echo "Du har stemmeret om et år.";
           } else {
               echo "Du har ikke stemmeret.";
           }
    ?>
    </body>
</html>
