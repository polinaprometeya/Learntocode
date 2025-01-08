using System;

public class UnusedCode
{
	public UnusedCode()
	{
        //graphCopyOfBejaminWork();
        //fiveWordsCopyOfBenjaminWork();
    }
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
