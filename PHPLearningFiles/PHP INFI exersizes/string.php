<?php

declare (strict_types=1);

// Task 1: Reverse a String
// Write a function that takes a string as input and returns the string reversed.
function reverseString(string $string): string
{
    // TODO add missing code
}


$reverseString = "This is a string";
echo reverseString($reverseString); // Output: "gnirts a si sihT"

// ---------------------------------------------------------------------------------------------------------------------------------------

// Task 2: Check if a String is a Palindrome
// Write a function that takes a string as input and returns true if the string is a palindrome, and false otherwise. 
// A palindrome is a word, phrase, number, or other sequences of characters that reads the same forward and backward.
function isPalindrome(string $string): bool 
{
    // TODO add missing code
}

$palindromeA = "racecar";
echo isPalindrome($palindromeA) ? "true" : "false"; // Output: true

$palindromeB = "rainbow";
echo isPalindrome($palindromeB) ? "true" : "false"; // Output: false

// ---------------------------------------------------------------------------------------------------------------------------------------

// Task 3: Capitalize the First Letter of Each Word
// Write a function that takes a string as input and returns the string with the first letter of each word capitalized.
function capitalizeWords(string $string) 
{
    // TODO add missing code
}

// ---------------------------------------------------------------------------------------------------------------------------------------

// Task 9: Anagram Check
// Write a function that takes two strings as input and returns true if they are anagrams of each other, and false otherwise.
// An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
function areAnagrams(string $stringA, string $stringB): bool
{
    // TODO add missing code
}

$s1 = "listen";
$s2 = "silent";
echo areAnagrams($s1, $s2) ? 'true' : 'false';  // Output: true

$s1 = "hello";
$s2 = "world";
echo areAnagrams($s1, $s2) ? 'true' : 'false';  // Output: false

// ---------------------------------------------------------------------------------------------------------------------------------------

// Task 10: to camel case
// Write a function that takes a string with words separated by spaces or underscores and converts it to camelCase.
function toCamelCase(string $string): string
{
    // TODO add missing code
}

$s = "hello world";
echo toCamelCase($s);  // Output: "helloWorld"

$s = "my_php Task";
echo toCamelCase($s);  // Output: "myPhpTask"