using System;

public class UnusedApocolypseCode
{
	public UnusedApocolypseCode()
	{
        //graphCopyOfBejaminWork();
        //fiveWordsCopyOfBenjaminWork();
    }

//    using System;
//using System.Windows;
//using Microsoft.Win32;
//using fwflClassLib;

//namespace wordsGUIWPF
//{
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();


//        }

//        // File Picker Button Click Handler
//        private void FilePickerButton_Click(object sender, RoutedEventArgs e)
//        {
//            // Open file dialog to select a file
//            OpenFileDialog openFileDialog = new OpenFileDialog();
//            openFileDialog.Filter = "All Files (*.*)|*.*"; // Specify file filter
//            if (openFileDialog.ShowDialog() == true)
//            {
//                // Get the selected file path
//                string selectedFilePath = openFileDialog.FileName;
//                MessageBox.Show($"File Selected: {selectedFilePath}");
//            }
//        }

//        // Reset Button Click Handler
//        private void ResetButton_Click(object sender, RoutedEventArgs e)
//        {
//            // Reset sliders to initial values
//            Slider1.Value = 0;
//            Slider2.Value = 0;
//        }
//    }
//}


    //Prints the result on the screen
    /*for (int i = 0; i < Listof5letterWord.Count; i++)
    {
        Console.Write("{0}: ", i);
        for (int j = 0; j < Listof5letterWord[i].Count; j++)
        {
            Console.Write(Listof5letterWord[i][j]);
            Console.Write(", ");
        }
        Console.Write("\n");
    }*/

    ////This is to see if the given word does not repeat characters.
    //public static List<string> modifiedWordList(string[] fileContentsArray)
    //{
    //    List<string> modifiedWordList = new List<string>();

    //    //go through the the loaded data one word at the time
    //    foreach (string word in fileContentsArray)
    //    {
    //        if (!isWordValid(word)) continue;
    //        if (word.Length != word.Distinct().Count()) continue;
    //        modifiedWordList.Add(word);
    //    }

    //    return modifiedWordList;
    //}

    ////here we are removing the words that repeat, if they do. 
    //public static List<string> uniqueWordList(List<string> modifiedWordLis)
    //{
    //    List<string> uniqueWordList = new List<string>();
    //    //List<string> uniqueWords = modifiedWordLis.Distinct();

    //    for (int i = 0; i < modifiedWordLis.Count() - 1; i++)
    //    {
    //        bool stringUniquness = areTwoStringThesame(modifiedWordLis[i], modifiedWordLis[i + 1]);
    //        if (stringUniquness == false) { uniqueWordList.Add($"{modifiedWordLis[i]}"); }
    //    }

    //    return uniqueWordList;
    //}

    //this is to make sets of 5 words combination. 

    //static List<List<string>> theFiveWordSet(List<string> listResult)
    //{
    //    List<List<string>> fullwordlist = new List<List<string>>();

    //    //go through the the  data one word at the time
    //    for (int i = 0; i < listResult.Count(); i++) //Find Word 1
    //    {
    //        //5-word, word list 
    //        List<string> wordList = new List<string>();
    //        //Alphabet of allowed characters
    //        string alphabetStack = new string("abcdefghijklmnopqrstuvwxyz");
    //        //Temporary Alphabet used for editing before changes are transfered to aphaetStack
    //        string alphabetStackTemporary = alphabetStack;
    //        //Find Word 1 
    //        string word = listResult[i];
    //        //Get word from the full word list & Remove letters used by the word from the alphaber of allowed characters
    //        removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);
    //        //Chech if 5 unique characters have been removed from the alphabet.
    //        if (check(ref alphabetStackTemporary, ref alphabetStack))
    //        {
    //            //Add the unique word to the 5 word list.
    //            wordList.Add(listResult[i]);

    //            for (int j = i; j < listResult.Count(); j++)            //Find Word 2
    //            {
    //                word = listResult[j];
    //                removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);

    //                if (check(ref alphabetStackTemporary, ref alphabetStack))
    //                {
    //                    wordList.Add(listResult[j]);

    //                    for (int k = j; k < listResult.Count(); k++)        //Find Word 3
    //                    {
    //                        word = listResult[k];
    //                        removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);
    //                        if (check(ref alphabetStackTemporary, ref alphabetStack))
    //                        {
    //                            wordList.Add(listResult[k]);

    //                            for (int l = k; l < listResult.Count(); l++)    //Find Word 4
    //                            {
    //                                word = listResult[l];
    //                                removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);
    //                                if (check(ref alphabetStackTemporary, ref alphabetStack))
    //                                {
    //                                    wordList.Add(listResult[l]);


    //                                    for (int m = l; m < listResult.Count(); m++)    //Find Word 5
    //                                    {
    //                                        word = listResult[m];
    //                                        removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);
    //                                        if (check(ref alphabetStackTemporary, ref alphabetStack))
    //                                        {
    //                                            wordList.Add(listResult[m]);
    //                                            fullwordlist.Add(wordList);            //Add the 5 word list to the set of lists.
    //                                        }
    //                                    }
    //                                }
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //    }
    //    return fullwordlist;
    //}
    //static void removeLetters(string word, ref string alphabetStackTemporary, ref string alphabetStack)
    //{
    //    char[] wordAsCharArray = word.ToCharArray();

    //    alphabetStackTemporary = alphabetStack;

    //    //Cycle through each character of the word
    //    foreach (char c in wordAsCharArray)
    //    {
    //        //Cycle through the alphabet to see if the word character is present. 
    //        foreach (char alphabet in alphabetStackTemporary)
    //            if (c == alphabet)
    //            { alphabetStackTemporary = alphabetStackTemporary.Replace(c.ToString(), string.Empty); } //Remove the character from the alphaber, so it cannot be reused later.
    //    }
    //}

    //static bool check(ref string alphabetStackTemporary, ref string alphabetStack)
    //{
    //    bool fiveUniqueLetters = false;

    //    //Check if 5 new letters have been removed from the temporary alphaber, if true, transfer changes to the alphabet.
    //    if (alphabetStackTemporary.Length == alphabetStack.Length - 5)
    //    {
    //        alphabetStack = alphabetStackTemporary;
    //        fiveUniqueLetters = true;
    //    }
    //    return fiveUniqueLetters;
    //}


    ////Products are equal if their names and product numbers are equal.
    //public static bool areTwoStringThesame(string firstString, string secondString)
    //{
    //    bool isSame = false;

    //    for (int i = 0; i < firstString.Length; i++)
    //    {
    //        int x;

    //        for (x = 0; x < secondString.Length; x++)
    //        {
    //            if (firstString[i] == secondString[x])
    //            {
    //                isSame = true;
    //                return true;
    //            }
    //        }

    //    }

    //    return isSame;
    //}

    //this is to make sets of 5 words combination. 

    //static List<List<string>> theFiveWordSet(List<string> wordList)
    //{
    //    List<List<string>> fullwordlist = new List<List<string>>();

    //    //go through the the  data one word at the time
    //    for (int i = 0; i < listResult.Count(); i++) //Find Word 1
    //    {

    //        if (wordList.Count() < 5) { recursiveFiveWordList(List<string> listResult) }
    //        else { return wordList};


    //    }
    //    return fullwordlist;
    //}

    //private static List<string> recursiveFiveWordList(List<string> listResult)
    //{
    //    //5-word, word list 
    //    List<string> wordList = new List<string>();
    //    //Alphabet of allowed characters
    //    string alphabetStack = new string("abcdefghijklmnopqrstuvwxyz");
    //    //Temporary Alphabet used for editing before changes are transfered to aphaetStack
    //    string alphabetStackTemporary = alphabetStack;
    //    //Find Word 1 
    //    string word = listResult[i];
    //    //Get word from the full word list & Remove letters used by the word from the alphaber of allowed characters
    //    removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);
    //    //Chech if 5 unique characters have been removed from the alphabet.

    //    if (wordList.Count() < 5)
    //    {
    //        if (check(ref alphabetStackTemporary, ref alphabetStack))
    //        {
    //            //Add the unique word to the 5 word list.
    //            wordList.Add(listResult[i]);

    //            for (int j = i; j < listResult.Count(); j++)            //Find Word 2
    //            {
    //                word = listResult[j];
    //                removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);



    //            }
    //        }
    //    }
    //    return wordList;

    //}



    // soooo what if i combine all i tried to learn into one function? It is easier they say , it will be fun they sey.
    //static List<List<string>> theFiveLetters(string[] fileContentList)
    //{
    //    List<List<string>> fullwordlist = new List<List<string>>();

    //    //go through the the perfect data one word at the time
    //    for (int i = 0; i < fileContentList.Length; i++) //Find Word 1
    //    {
    //        List<string> wordList = new List<string>();                         //5-word, word list 
    //        string alphabetStack = new string("abcdefghijklmnopqrstuvwxyz");    //Alphabet of allowed characters
    //        string alphabetStackTemporary = alphabetStack;                     //Temporary Alphabet used for editing before changes are transfered to aphaetStack

    //        string word = fileContentList[i];                                               //Get word from the full word list 
    //        removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);           //Remove letters used by the word from the alphaber of allowed characters

    //        if (check(ref alphabetStackTemporary, ref alphabetStack))                  //Chech if 5 unique characters have been removed from the alphabet.
    //        {
    //            wordList.Add(fileContentList[i]);                                       //Add the unique word to the 5 word list.

    //            for (int j = i; j < fileContentList.Length; j++)            //Find Word 2
    //            {
    //                word = fileContentList[j];
    //                removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);

    //                if (check(ref alphabetStackTemporary, ref alphabetStack))
    //                {
    //                    wordList.Add(fileContentList[j]);

    //                    for (int k = j; k < fileContentList.Length; k++)        //Find Word 3
    //                    {
    //                        word = fileContentList[k];
    //                        removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);
    //                        if (check(ref alphabetStackTemporary, ref alphabetStack))
    //                        {
    //                            wordList.Add(fileContentList[k]);

    //                            for (int l = k; l < fileContentList.Length; l++)    //Find Word 4
    //                            {
    //                                word = fileContentList[l];
    //                                removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);
    //                                if (check(ref alphabetStackTemporary, ref alphabetStack))
    //                                {
    //                                    wordList.Add(fileContentList[l]);


    //                                    for (int m = l; m < fileContentList.Length; m++)    //Find Word 5
    //                                    {
    //                                        word = fileContentList[m];
    //                                        removeLetters(word, ref alphabetStackTemporary, ref alphabetStack);
    //                                        if (check(ref alphabetStackTemporary, ref alphabetStack))
    //                                        {
    //                                            wordList.Add(fileContentList[m]);
    //                                            fullwordlist.Add(wordList);            //Add the 5 word list to the set of lists.
    //                                        }
    //                                    }
    //                                }
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //    }
    //    return fullwordlist;
    //}

    //static void removeLetters(string word, ref string alphabetStackTemporary, ref string alphabetStack)
    //{
    //    char[] wordAsCharArray = word.ToCharArray();

    //    alphabetStackTemporary = alphabetStack;

    //    //Cycle through each character of the word
    //    foreach (char c in wordAsCharArray)
    //    {
    //        //Cycle through the alphabet to see if the word character is present. 
    //        foreach (char alphabet in alphabetStackTemporary)
    //            if (c == alphabet)
    //            { alphabetStackTemporary = alphabetStackTemporary.Replace(c.ToString(), string.Empty); } //Remove the character from the alphaber, so it cannot be reused later.
    //    }
    //}

    //static bool check(ref string alphabetStackTemporary, ref string alphabetStack)
    //{
    //    bool fiveUniqueLetters = false;

    //    //Check if 5 new letters have been removed from the temporary alphaber, if true, transfer changes to the alphabet.
    //    if (alphabetStackTemporary.Length == alphabetStack.Length - 5)
    //    {
    //        alphabetStack = alphabetStackTemporary;
    //        fiveUniqueLetters = true;
    //    }
    //    return fiveUniqueLetters;
    //}


    //static bool isFiveLettersWordOkay(string word)
    //{
    //    char[] wordAsCharArray = word.ToCharArray();
    //    bool isWordOkay = false;

    //    //check each word for repetition and if the characters are unique  add it to new list
    //    for (int i = 0; i < word.Length - 1; i++)
    //    {
    //        if (wordAsCharArray[i] != wordAsCharArray[i + 1]) { isWordOkay = true; }{ isWordOkay = false; }
    //    }
    //    Console.WriteLine(word, isWordOkay);

    //    return isWordOkay;

    //}

    //wordArray[i] == wordArray[i + 1] ? isWordOkay = false : isWordOkay = true; 
    //static void isFiveLettersWordOkay(string[] fileContentsArray)
    //{
    //    List<string> wordsList = new List<string>();
    //    Stack<char> alphabetStack = new Stack<char>("abcdefghijklmnopqrstuvwxyz".ToCharArray());


    //    //go through the the perfect data one word at the time
    //    foreach (string word in fileContentsArray)
    //    {
    //        char[] wordArray = word.ToCharArray();
    //        int alphabetCount = 26;

    //        //check each word for repetition and remove all used alphabet characters from the alphabet string. 
    //        //Console.WriteLine(word);
    //        for (int i = 0; i < alphabetCount.count; i++)
    //        {


    //        }
    //        for (int i = 1; i < 5; i++)
    //        {
    //            if (wordArray[i] == wordArray[i - 1])
    //            {
    //                //this is not php and therefore pop needs some help along. 
    //                wordArray[i] = alphabetStack.Pop(); // Pop a new letter from the stack
    //                alphabetCount--;
    //            }

    //        }

    //        for (int i = 1; i < fileContentList.Length; i++)
    //        {
    //            if (fileContentList[i] != fileContentList[i - 1])
    //            {
    //                // Rebuild the word after modification
    //                string modifiedWord = new string(wordArray);
    //                wordsList.Add(modifiedWord); // Add the word to the list after processing
    //            }
    //        }
    //    }

    //-------------------------------------------------------------------------------
    //static void readData()
    //{
    //    string dataAllPerfect = @"dataAllPerfect.txt";

    //    if (File.Exists(dataAllPerfect))
    //    {
    //        Console.WriteLine("File found");
    //        try
    //        {
    //            string[] fileContentsArray = File.ReadAllLines(dataAllPerfect);
    //            // StreamWriter writer = new StreamWriter(dataAllPerfect);

    //            //Console.WriteLine("File content ");
    //            //for (var i = 0; i < fileContentsArray.Length; i++)
    //            //{ Console.WriteLine($"Line #{i + 1}: " + fileContentsArray[i]);}
    //            //List<string> fileContentList = fileContentsArray.ToList();

    //            theFiveLetters(fileContentsArray);
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Error or something: " + ex.Message);
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine("Error, no file exist");
    //    }
    //}

    //this is a grayveyard--------------------------------------------------------------------------------------

    //this is a grayveyard for all the alphabet variable version in order to sset the right types 
    //static void alphabet()
    //{
    //string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    //char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    //string alphabet = "abcdefghijklmnopqrstuvwxyz";
    //string alphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
    //Stack<string> alphabetStack = new Stack<string>(alphabet.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries));
    //  Stack<string> alphabet = "abcdefghijklmnopqrstuvwxyz";
    //}

    //this the grayveyard for the validation ideas I run for my self in different places.
    //static void someValidation()
    //{

    //string combinedString = string.Join(",", fileContentList);
    //int countSeperateWords = combinedString.Split(",").Length - 1;
    //int characterCount = combinedString.Length;
    //if (characterCount > 0 && characterCount < 29 && countSeperateWords ==4)
    //{Console.WriteLine("Success it is correct file that is loaded");}
    //}

    //this is a Bejamins example--------------------------------------------------------------------------------------
    //This is converted code from the exersize set. The Benjamin work from the video. THe sin the pledge the murder. 
    //    static void graphCopyOfBejaminWork()
    //    {
    //        try
    //        {

    //            //so this is basically like perfect data stuff. the word for it self , the characters in that word and how many there are. 
    //            // Prepare a data structure for all five-letter words in string and set representation
    //            List<(string word, HashSet<char> charSet, HashSet<int> neighbors)> words = new List<(string, HashSet<char>, HashSet<int>)>();

    //            Console.WriteLine("--- reading words file ---");

    //            //i just dowenloaded this file so....
    //            // Reading the words file (wordsAlpha.txt)
    //            string[] lines = File.ReadAllLines(@"C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FiveWordFiveLetters\\wordsAlpha.txt");
    //            foreach (var line in lines)
    //            {
    //                string word = line.Trim();
    //                if (word.Length != 5)
    //                {
    //                    continue;
    //                }

    //                // Compute set representation of the word. where all my array stuff...
    //                HashSet<char> charSet = new HashSet<char>(word);
    //                if (charSet.Count != 5)
    //                {
    //                    continue;
    //                }

    //                // Append the word, the set of characters in the word, and an empty set for all the 'neighbors' of the word
    //                words.Add((word, charSet, new HashSet<int>()));
    //            }

    //            Console.WriteLine("--- building neighborhoods ---");

    //            // Compute the 'neighbors' for each word, i.e., other words which have entirely distinct letters
    //            for (int i = 0; i < words.Count; i++)
    //            {
    //                var charSet = words[i].charSet;
    //                var neighbors = words[i].neighbors;
    //                for (int j = 0; j < words.Count; j++)
    //                {
    //                    if (!charSet.Intersect(words[j].charSet).Any()) // Check if no common letters
    //                    {
    //                        neighbors.Add(j);
    //                    }
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Error in reading word file: " + ex.Message);
    //        }



    //        //check out the right way to do the whole try catch thing. 
    //        Console.WriteLine("--- write to output ---");

    //        try
    //        {
    //            //well he made a csv and I am not into that so it is just a txt documents. I do not have word on my computer yet. maybe soon.
    //            // Write to output file (wordGraph.txt)
    //            using (StreamWriter writer = new StreamWriter(@"C:\Users\infi-yoga\source\repos\CSharpLearningFiles\FiveWordFiveLetters\wordGraph.txt"))
    //            {
    //                foreach (var word in words)
    //                {
    //                    writer.WriteLine($"{word.word}\t{string.Join(",", word.neighbors.OrderBy(n => n))}");
    //                }
    //            }

    //            //  THis is kinda JavaScrip of me... but I am tained from that world :'(
    //            Console.WriteLine("Finished! --- direct load of the next step.");
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Error in writing the output.: " + ex.Message);
    //        }
    //        // Starting the next step
    //        //fiveWordsCopyOfBenjaminWork();

    //    }

    //    static void fiveWordsCopyOfBenjaminWork()
    //    {
    //        Console.WriteLine("--- loading graph ---");

    //        // Load the graph from 'word_graph.csv'
    //        List<(string word, HashSet<int> neighbors)> words = new List<(string, HashSet<int>)>();

    //        string[] lines = File.ReadAllLines("word_graph.csv");
    //        foreach (var line in lines)
    //        {
    //            var row = line.Split('\t');
    //            string word = row[0];
    //            var neighborString = row[1];
    //            var neighbors = new HashSet<int>(neighborString.Trim('[', ']').Split(", ").Select(int.Parse));

    //            words.Add((word, neighbors));
    //        }

    //        Console.WriteLine("--- start clique finding (THIS WILL TAKE LONG!) ---");

    //        // Start clique finding
    //        List<List<int>> Cliques = new List<List<int>>();
    //        for (int i = 0; i < words.Count; i++)
    //        {
    //            var Ni = words[i].neighbors;
    //            foreach (var j in Ni)
    //            {
    //                if (j < i)
    //                    continue;

    //                // The remaining candidates are only the words in the intersection
    //                // of the neighborhood sets of i and j
    //                var Nij = Ni.Intersect(words[j].neighbors).ToHashSet();
    //                if (Nij.Count < 3)
    //                    continue;

    //                foreach (var k in Nij)
    //                {
    //                    if (k < j)
    //                        continue;

    //                    // Intersect with neighbors of k
    //                    var Nijk = Nij.Intersect(words[k].neighbors).ToHashSet();
    //                    if (Nijk.Count < 2)
    //                        continue;

    //                    foreach (var l in Nijk)
    //                    {
    //                        if (l < k)
    //                            continue;

    //                        // Intersect with neighbors of l
    //                        var Nijkl = Nijk.Intersect(words[l].neighbors).ToHashSet();
    //                        // All remaining neighbors form a 5-clique with i, j, k, and l
    //                        foreach (var r in Nijkl)
    //                        {
    //                            if (r < l)
    //                                continue;

    //                            Cliques.Add(new List<int> { i, j, k, l, r });
    //                        }
    //                    }
    //                }
    //            }
    //        }

    //        Console.WriteLine($"completed! Found {Cliques.Count} cliques");

    //        Console.WriteLine("--- write to output ---");

    //        // Write to output file 'cliques.csv'
    //        using (StreamWriter writer = new StreamWriter("cliques.csv"))
    //        {
    //            foreach (var cliq in Cliques)
    //            {
    //                // Get word representation of cliques and write to output
    //                var cliqWords = cliq.Select(index => words[index].word).ToList();
    //                writer.WriteLine(string.Join("\t", cliqWords));
    //            }
    //        }

    //        Console.WriteLine("Finished!");
    //    }
}
