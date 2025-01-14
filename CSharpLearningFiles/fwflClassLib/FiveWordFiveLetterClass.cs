using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fwflClassLib
{
    public  class FiveWordFiveLetterClass
    {

        public int _wordLength;
        public int _wordCount;
        public  Dictionary<int, string> _dictionary;
        public  List<string> _solutions;
        //string filename = "wordsAlpha.txt";
        //string filename = "dataAllPerfect.txt";
        string _filename;

        public  FiveWordFiveLetterClass(string filename, int _wordLength = 5, int _wordCount = 5) 
        { 
            this._filename = filename;
        
        }

        public Task DoWork()
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(100);
                    OnUpdateSearchIndex(i);
                }
            });
        }

        public event EventHandler<int> SearchIndex;

        protected virtual void OnUpdateSearchIndex(int e)
        {
            EventHandler<int> handler = SearchIndex;
            if (handler != null)
            {
                handler(this, e);
            }
        }
            

        public void Run()
        {
            Console.WriteLine("Hello, World!");
            Stopwatch sw = Stopwatch.StartNew(); // make a new stopwatch to take count.


            string[] fileContentsArray = readData(_filename); //Read and load data here into an Array. You cannot chnage an array in c#.

            Console.Write("Original list word count:  ");
            Console.WriteLine(fileContentsArray.Count()); // check word count in original file
            Console.Write("\n");

            List<string> modifiedWords = modifiedWordList(fileContentsArray); //checking loaded data word for word - so they good.
            _solutions = new List<string>(); //making new string 
            _dictionary = uniqueWordDictionary(modifiedWords); // prooning the modifiedWordList word with BIT stuff to remove doublicates , anagrams etc.


            recurciveFiveWordSet(_dictionary.Keys.ToArray(), 0, 0, new List<string>());

            // Print a list of strings. Each string represents a set of 5 words with five unique letters, each set have alphabet represented once. 
            foreach (string word in _solutions)
            {
                Console.WriteLine(word); // print each word set as a  string
            }
            Console.WriteLine($"\nsolutions: {_solutions.Count}"); //count how many word sets there are

            Console.Write("\n");
            Console.Write("The count of unique words is: ");
            Console.WriteLine(_dictionary.Count()); //check word count in prooned and cleaned data 

            sw.Stop(); //stop the timer
            Console.WriteLine($"Time used: {sw.Elapsed.TotalSeconds:F2} sekunder used"); //print the time used
            Console.Write("\n");

        }

        
        // loading the "perfect" data for first run, then just the data file we are interested in this passes the values down to function that checks if the words are okay.
        public  string[] readData(string filePath)
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

        // this checks 
        private  void recurciveFiveWordSet(int[] keys, int index, int mask, List<string> words)
        {
            for (int i = index; i < keys.Length; i++)
            {
                if ((keys[i] & mask) == 0) //check unique letters
                {
                    var newList = new List<string>(words);
                    newList.Add(_dictionary[keys[i]]);
                    if (newList.Count == _wordCount)
                    {
                        //TODO: Add to global list
                        _solutions.Add(string.Join(' ', newList));
                    }
                    else
                    {
                        recurciveFiveWordSet(keys, i + 1, mask | keys[i], newList);
                    }

                }
            }


        }

        //basic test if word is there and it is 5 characters long.
        public  bool isWordValid(string word)
        {
            if (word.Length == _wordLength) return true; return false;
        }

        //This is to see if the given word does not repeat characters.
        public  List<string> modifiedWordList(string[] fileContentsArray)
        {
            List<string> modifiedWordList = new List<string>();

            //go through the the loaded data one word at the time
            foreach (string word in fileContentsArray)
            {
                if (!isWordValid(word)) continue;
                if (word.Length != word.Distinct().Count()) continue;
                modifiedWordList.Add(word);
            }

            return modifiedWordList;
        }


        //  We are making a new collection of keys and values called dictionery.
        //  Foreach proons the list of words by translating to binery value , and before adding a value to the list it checks if the binery value is unique.
        private  Dictionary<int, string> uniqueWordDictionary(List<string> modifiedWords)
        {
            var dictionary = new Dictionary<int, string>();

            foreach (string word in modifiedWords)
            {
                var bit = 0;
                foreach (char c in word)
                {
                    bit = bit | (1 << c - 'a');
                }
                if (dictionary.ContainsKey(bit)) continue;
                dictionary.Add(bit, word);
            }

            return dictionary;
        }


        
    }
}
