using System.Collections.Generic;

internal class FiveWordFiveLetterClass
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        //string filename = "newBeta.txt";
        string filename = "dataAllPerfect.txt";


        string[] fileContentsArray = readData(projectDirectory + "\\" + filename);
        //modifiedWordList(fileContentsArray);
        Console.Write("Original list word count:  ");
        Console.WriteLine(fileContentsArray.Count());
        Console.Write("\n");

        List<string> modifiedWords= modifiedWordList(fileContentsArray);
        List<string> listResult = uniqueWordList(modifiedWords);

        foreach (string word in listResult)
        {
            Console.Write(word);
            Console.Write("\n");
        }

        Console.Write("\n");
        Console.Write("The count of unique words is: ");
        Console.WriteLine(listResult.Count());
        Console.Write("\n");

        List<List<string>> Listof5letterWord = theFiveWordSet(listResult);

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
    public static string[] readData(string filePath)
    {


        if (File.Exists(filePath))
        {
            Console.WriteLine("File found");
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

    //This is to see if the given word does not repeat characters.
    public static List<string> modifiedWordList(string[] fileContentsArray)
    {
        List<string> modifiedWordList = new List<string>();

        //go through the the perfect data one word at the time
        foreach (string word in fileContentsArray)
        { bool valid = isWordValid(word);
            if (valid == true)
            {
                char[] wordAsCharArray = word.ToCharArray();
                bool isWordOkay = false;

                for (int i = 0; i < wordAsCharArray.Length - 1; i++)
                {
                    if (wordAsCharArray[i] == wordAsCharArray[i + 1]) { isWordOkay = false; }
                    { isWordOkay = true; }
                }

                if (isWordOkay == true) { modifiedWordList.Add(word); }
            }
        }

        return modifiedWordList;
    }

    //here we are removing the words that repeat, if they do. 
    public static List<string> uniqueWordList(List<string> modifiedWordLis)
    {
        //List<string> uniqueWordList = new List<string>();
        List<string> uniqueWords = modifiedWordLis.Distinct();

        //List<string> uniqueWordList = new List<string>();
        //for (int i = 0; i < modifiedWordLis.Count() - 1; i++)
        //{
        //      bool stringUniquness = areTwoStringThesame(modifiedWordLis[i], modifiedWordLis[i + 1]);
        //        if (stringUniquness == false){uniqueWordList.Add($"{modifiedWordLis[i]}"); }
        //        else { modifiedWordLis.Remove($"{modifiedWordLis[i]}"); }
        //}

        return uniqueWords;
    }

    //this is to make sets of 5 words combination. 
    static List<List<string>> theFiveWordSet(List<string> listResult)
    {
        List<List<string>> theFiveWordSet = new List<List<string>>();

        //go through the the perfect data one word at the time
        for (int i = 0; i < listResult.Length; i++) //Find Word 1
        {
            List<string> wordList = new List<string>();                         //5-word, word list 
            string alphabetStack = new string("abcdefghijklmnopqrstuvwxyz");    //Alphabet of allowed characters
            string alphabetStackTemporary = alphabetStack;                     //Temporary Alphabet used for editing before changes are transfered to aphaetStack

            string word = listResult[i];                                               //Get word from the full word list 
            removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);           //Remove letters used by the word from the alphaber of allowed characters

            if (check(ref alphabetStackTemporary, ref alphabetStack))                  //Chech if 5 unique characters have been removed from the alphabet.
            {
                wordList.Add(listResult[i]);                                       //Add the unique word to the 5 word list.

                for (int j = i; j < listResult.Length; j++)            //Find Word 2
                {
                    word = listResult[j];
                    removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);

                    if (check(ref alphabetStackTemporary, ref alphabetStack))
                    {
                        wordList.Add(listResult[j]);

                        for (int k = j; k < listResult.Length; k++)        //Find Word 3
                        {
                            word = listResult[k];
                            removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);
                            if (check(ref alphabetStackTemporary, ref alphabetStack))
                            {
                                wordList.Add(listResult[k]);

                                for (int l = k; l < listResult.Length; l++)    //Find Word 4
                                {
                                    word = listResult[l];
                                    removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);
                                    if (check(ref alphabetStackTemporary, ref alphabetStack))
                                    {
                                        wordList.Add(listResult[l]);


                                        for (int m = l; m < listResult.Length; m++)    //Find Word 5
                                        {
                                            word = listResult[m];
                                            removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);
                                            if (check(ref alphabetStackTemporary, ref alphabetStack))
                                            {
                                                wordList.Add(listResult[m]);
                                                theFiveWordSet.Add(wordList);            //Add the 5 word list to the set of lists.
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
        return theFiveWordSet;
    }

    static void removeLetters(string word, ref string alphabetStackTemporary, ref string alphabetStack)
    {
        char[] wordAsCharArray = word.ToCharArray();

        alphabetStackTemporary = alphabetStack;

        //Cycle through each character of the word
        foreach (char c in wordAsCharArray)
        {
            //Cycle through the alphabet to see if the word character is present. 
            foreach (char alphabet in alphabetStackTemporary)
                if (c == alphabet)
                { alphabetStackTemporary = alphabetStackTemporary.Replace(c.ToString(), string.Empty); } //Remove the character from the alphaber, so it cannot be reused later.
        }
    }

    static bool check(ref string alphabetStackTemporary, ref string alphabetStack)
    {
        bool fiveUniqueLetters = false;

        //Check if 5 new letters have been removed from the temporary alphaber, if true, transfer changes to the alphabet.
        if (alphabetStackTemporary.Length == alphabetStack.Length - 5)
        {
            alphabetStack = alphabetStackTemporary;
            fiveUniqueLetters = true;
        }
        return fiveUniqueLetters;
    }

    //basic test if word is there and it is 5 characters long.
    public static bool isWordValid( string word)
    {
        if (word.Length == 5 && word != null) return true; return false;
    }

    //Products are equal if their names and product numbers are equal.
    public static bool areTwoStringThesame(string firstString, string secondString)
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