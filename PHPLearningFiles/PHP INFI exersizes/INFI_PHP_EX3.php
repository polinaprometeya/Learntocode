<?php
declare (strict_types=1);

// Task 3: Capitalize the First Letter of Each Word
// Write a function that takes a string as input and returns the string with the first letter of each word capitalized.

function capitalizeWords(string $string) 
{
  if ($string !== ''){
    // TODO add missing code
   $string = ucwords($string);
  } 
  
  
  return $string;
}



$sentance = "deja vu, deja su, deja vacu";
echo capitalizeWords($sentance);
