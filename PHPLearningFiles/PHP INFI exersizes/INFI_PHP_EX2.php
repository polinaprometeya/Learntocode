<?php
declare (strict_types=1);

// Task 2: Check if a String is a Palindrome
// Write a function that takes a string as input and returns true if the string is a palindrome, and false otherwise. 
// A palindrome is a word, phrase, number, or other sequences of characters that reads the same forward and backward.


function isPalindrome(string $string): bool 
{
    $pelandrome = strrev($string);
    if ( $string === $pelandrome){
        return true;
    } else { 
        return false;}
}




$palindromeA = "racecar";
echo isPalindrome($palindromeA) ? "true" : "false"; // Output: true

echo "\r\n";

$palindromeB = "rainbow";
echo isPalindrome($palindromeB) ? "true" : "false"; // Output: false