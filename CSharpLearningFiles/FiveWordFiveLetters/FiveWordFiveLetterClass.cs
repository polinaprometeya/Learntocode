using System.Runtime.InteropServices;

internal class FiveWordFiveLetterClass
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        try
        {
            readData();
        }   
        catch (Exception ex)
        {
             Console.WriteLine("Error or something: " + ex.Message);
        }

    }


    // loading the "perfect" data for first run, then just the data file we are interested in this passes the values down to function that checks if the words are okay.
    static void readData()
    {
        string dataAllPerfect = @"dataAllPerfect.txt";

        if (File.Exists(dataAllPerfect))
        {
            Console.WriteLine("File found");
            
            
                string[] fileContentsArray = File.ReadAllLines(dataAllPerfect);
                modifiedWordList(fileContentsArray);
            

        }
        else
        {
            Console.WriteLine("Error, no file exist");
        }
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

        //List<string> uniqueWordsList = new List<string>();
        //for (int i = 0; i < modifiedWordList.Count() - 1; i++)
        //{
        //    string currentWord = modifiedWordList[i];
        //    string nextWord = modifiedWordList[i + 1];

        //    bool isunique = isWordUnique(string currentWord, string nextWord);
        //    if (isunique)
        //    {
        //        uniqueWordsList.Add(currentWord);
        //        Console.WriteLine(currentWord);
        //    }
        //}
    }

    //static void uniqueWordList()
    //{
    //}

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