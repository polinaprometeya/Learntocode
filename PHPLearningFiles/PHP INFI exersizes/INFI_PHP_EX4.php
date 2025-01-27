<?php
declare (strict_types=1);

// Task 9: Anagram Check
// Write a function that takes two strings as input and returns true if they are anagrams of each other, and false otherwise.
// An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
function areAnagrams(string $stringA, string $stringB): bool
{
  if ($stringA !== '' && $stringB !=='') {
        $array_stringA =  str_split($stringA);
        $array_stringB =  str_split($stringB);
        sort($array_stringA);
        sort($array_stringB);

      if ($array_stringA == $array_stringB) { return true;} else {return false; }
  } else { echo "Error"; }
}



$s1 = "listen2";
$s2 = "silent2";
echo areAnagrams($s1, $s2) ? 'true' : 'false';  // Output: true

echo "\r\n";

$s1 = "hello";
$s2 = "world";
echo areAnagrams($s1, $s2) ? 'true' : 'false';  // Output: false