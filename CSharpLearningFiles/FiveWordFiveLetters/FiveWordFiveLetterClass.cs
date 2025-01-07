internal class FiveWordFiveLetterClass
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        readData();

    }


    // loading the "perfect" data for first run, this passes the values down to five letterfivewpord first version
    static void readData()
    {
        string dataAllPerfect = @"C:\\Users\\infi-yoga\\source\\repos\\CSharpLearningFiles\\FiveWordFiveLetters\\dataAllPerfect.txt";

        if (File.Exists(dataAllPerfect))
        {
            Console.WriteLine("File found");
            try
            {
                string[] fileContentsArray = File.ReadAllLines(dataAllPerfect);

                //Console.WriteLine("File content ");
                //for (var i = 0; i < fileContentsArray.Length; i++)
                //{ Console.WriteLine($"Line #{i + 1}: " + fileContentsArray[i]);}
                //List<string> fileContentList = fileContentsArray.ToList();

                theFiveLetters(fileContentsArray);
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
    }

    // soooo what if i combine all i tried to learn into one function? It is easier they say , it will be fun they sey.
    static void theFiveLetters(string[] fileContentList)
    {
        List<string> wordsList = new List<string>();
        Stack<char> alphabetStack = new Stack<char>("abcdefghijklmnopqrstuvwxyz".ToCharArray());


        //go through the the perfect data one word at the time
        foreach (string word in fileContentList)
        {
            char[] wordArray = word.ToCharArray();
            int alphabetCount = 26;

            //check each word for repetition and remove all used alphabet characters from the alphabet string. 
            //Console.WriteLine(word);
            for (int i = 1; i < 5; i++)
            {
                if (wordArray[i] == wordArray[i - 1])
                {
                    //this is not php and therefore pop needs some help along. 
                    wordArray[i] = alphabetStack.Pop(); // Pop a new letter from the stack
                    alphabetCount--;
                }

            }

            for (int i = 1; i < fileContentList.Length; i++)
            {
                if (fileContentList[i] != fileContentList[i - 1])
                {
                    // Rebuild the word after modification
                    string modifiedWord = new string(wordArray);
                    wordsList.Add(modifiedWord); // Add the word to the list after processing
                }
            }
        }

        // Output the result
        Console.WriteLine("Processed Words: ");
        foreach (var word in wordsList)
        {
            Console.WriteLine(word);
        }
    }

   
}