<?php
declare (strict_types=1);

// Task 10: to camel case
// Write a function that takes a string with words separated by spaces or underscores and converts it to camelCase.
function toCamelCase(string $string): string
{
    if($string !==''){
      $string = ucwords(str_replace('_'," ",$string));
      $string = lcfirst(str_replace(['-', '+',' '],"",$string));
    }
    return $string;
}



$s = "hello world";
echo toCamelCase($s);  // Output: "helloWorld"

echo "\r\n";

$s2 = "my_php Task"; 
echo toCamelCase($s2);  // Output: "myPhpTask"clear
