using System.Runtime.InteropServices;
using System;
using System.IO;
internal class FiveWordFiveLetterClass
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        string filename = "newBeta.txt";
        //string filename = "dataAllPerfect.txt";


        string[] fileContentsArray = readData(projectDirectory + "\\" + filename);
        List<List<string>> Listof5letterWord = theFiveLetters(fileContentsArray);

        for (int i = 0; i < Listof5letterWord.Count; i++)
        {
            Console.Write("{0}: ", i);
            for (int j = 0; j < Listof5letterWord[i].Count; j++)
            {
                Console.Write(Listof5letterWord[i][j]);
                Console.Write(", ");
            }
            Console.Write("\n");
        }

    }


    // loading the "perfect" data for first run, then just the data file we are interested in this passes the values down to function that checks if the words are okay.
    static string[] readData(string filePath)
    {
      

        if (File.Exists(filePath))
        {  Console.WriteLine("File found");
            try
            {
                //string[] fileContentsArray = File.ReadAllLines(dataAllPerfect);
                //modifiedWordList(fileContentsArray);

                string[] fileContentsArray = File.ReadAllLines(filePath);
                return fileContentsArray;

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error or something: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Error, no file exist");
        }
        return null;
    }

    // soooo what if i combine all i tried to learn into one function? It is easier they say , it will be fun they sey.
    static void modifiedWordList(string[] fileContentsArray)
    {
        List<string> modifiedWordList = new List<string>();
       

        //go through the the perfect data one word at the time
        foreach (string word in fileContentsArray)
            {
                bool isWordOkay = isFiveLettersWordOkay(word);
                if (isWordOkay)
                {
                    modifiedWordList.Add(word);
                    Console.WriteLine(word);
                }
            }

        Console.WriteLine("The count of unique words is: ", modifiedWordList.Count());

        uniqueWordList(modifiedWordList);
    }


    static void uniqueWordList(List<string> modifiedWordLis)
    {for (int i = 0; i< modifiedWordLis.Count()-1; i++)
        {

        }
        
    }


    // soooo what if i combine all i tried to learn into one function? It is easier they say , it will be fun they sey.
    static List<List<string>> theFiveLetters(string[] fileContentList)
    {
        List<List<string>> fullwordlist = new List<List<string>>();

        //go through the the perfect data one word at the time
        for (int i = 0; i < fileContentList.Length; i++) //Find Word 1
        {
            List<string> wordList = new List<string>();                         //5-word, word list 
            string alphabetStack = new string("abcdefghijklmnopqrstuvwxyz");    //Alphabet of allowed characters
            string alphabetStack_temporary = alphabetStack;                     //Temporary Alphabet used for editing before changes are transfered to aphaetStack

            string word = fileContentList[i];                                               //Get word from the full word list 
            removeLetters(word, ref alphabetStack_temporary, ref alphabetStack);           //Remove letters used by the word from the alphaber of allowed characters

            if (check(ref alphabetStack_temporary, ref alphabetStack))                  //Chech if 5 unique characters have been removed from the alphabet.
            {
                wordList.Add(fileContentList[i]);                                       //Add the unique word to the 5 word list.

                for (int j = i; j < fileContentList.Length; j++)            //Find Word 2
                {
                    word = fileContentList[j];
                    removeLetters(word, ref alphabetStack_temporary, ref alphabetStack);

                    if (check(ref alphabetStack_temporary, ref alphabetStack))
                    {
                        wordList.Add(fileContentList[j]);

                        for (int k = j; k < fileContentList.Length; k++)        //Find Word 3
                        {
                            word = fileContentList[k];
                            removeLetters(word, ref alphabetStack_temporary, ref alphabetStack);
                            if (check(ref alphabetStack_temporary, ref alphabetStack))
                            {
                                wordList.Add(fileContentList[k]);

                                for (int l = k; l < fileContentList.Length; l++)    //Find Word 4
                                {
                                    word = fileContentList[l];
                                    removeLetters(word, ref alphabetStack_temporary, ref alphabetStack);
                                    if (check(ref alphabetStack_temporary, ref alphabetStack))
                                    {
                                        wordList.Add(fileContentList[l]);


                                        for (int m = l; m < fileContentList.Length; m++)    //Find Word 5
                                        {
                                            word = fileContentList[m];
                                            removeLetters(word, ref alphabetStack_temporary, ref alphabetStack);
                                            if (check(ref alphabetStack_temporary, ref alphabetStack))
                                            {
                                                wordList.Add(fileContentList[m]);
                                                fullwordlist.Add(wordList);            //Add the 5 word list to the set of lists.
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        return fullwordlist;
    }

    static void removeLetters(string word, ref string alphabetStack_temporary, ref string alphabetStack)
    {
        char[] word_asCharArray = word.ToCharArray();

        alphabetStack_temporary = alphabetStack;

        //Cycle through each character of the word
        foreach (char c in word_asCharArray)
        {
            //Cycle through the alphabet to see if the word character is present. 
            foreach (char alphabet in alphabetStack_temporary)
                if (c == alphabet)
                { alphabetStack_temporary = alphabetStack_temporary.Replace(c.ToString(), string.Empty); } //Remove the character from the alphaber, so it cannot be reused later.
        }
    }

    static bool check(ref string alphabetStack_temporary, ref string alphabetStack)
    {
        bool fiveUniqueLetters = false;

        //Check if 5 new letters have been removed from the temporary alphaber, if true, transfer changes to the alphabet.
        if (alphabetStack_temporary.Length == alphabetStack.Length - 5)
        {
            alphabetStack = alphabetStack_temporary;
            fiveUniqueLetters = true;
        }
        return fiveUniqueLetters;
    }


    static bool isFiveLettersWordOkay(string word)
        {
            char[] wordArray = word.ToCharArray();
            bool isWordOkay = false;

            //check each word for repetition and if the characters are unique  add it to new list
            for (int i = 0; i < word.Length - 1; i++)
            {
                if (wordArray[i] != wordArray[i + 1]) isWordOkay = true; isWordOkay = false;
            }

            return isWordOkay;

        }
    public bool isWordValid(string word)
    {
        if (word.Length == 5) return true; return false;
    }

    // Products are equal if their names and product numbers are equal.
    public bool isWordUnique(string currentWord, string nextWord)
    {
        string x = currentWord;
        string y = nextWord;


        //Check whether any of the compared objects is null.
        if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
            return false;

        //Check whether the compared objects reference the same data.
        if (Object.ReferenceEquals(x, y)) return true; return false;

    }

    public bool areTwoStringThesame(string firstString, string secondString)
    {
        bool isSame = true;

        for (int i = 0; i < firstString.Length; i++)
        {
            int x;

            for (x = 0; x < secondString.Length; x++)
            {
                if (firstString[i] == secondString[x])
                {
                    break;
                }
            }

            if (x == secondString.Length)
            {
                isSame = false;
                break;
            }
        }

        return isSame;
    }


}