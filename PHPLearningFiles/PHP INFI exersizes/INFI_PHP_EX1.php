<?php

declare (strict_types=1);

// Task 1: Reverse a String
// Write a function that takes a string as input and returns the string reversed.
// time: 5 minute

function reverseString(string $string): string
{
  $string = strrev($string);
  return $string;
}




array_shift($argv);

$reverseString = implode(" ", $argv);
echo reverseString($reverseString); // Output: "gnirts a si sihT"

