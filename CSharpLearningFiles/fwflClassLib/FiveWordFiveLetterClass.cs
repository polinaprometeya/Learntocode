using System.Diagnostics;

namespace fwflClassLib
{
    public class FiveWordFiveLetterClass
    {
        private string _filename;
        private int _wordLength;
        private int _wordCount;
        public double _runtime;

        private Dictionary<int, string> _dictionary;
        public List<string> _solutions;

        

        public FiveWordFiveLetterClass(string filename, int wordLength = 5, int wordCount = 5)
        {
            this._filename = filename;
            _wordCount = wordCount;
            _wordLength = wordLength;
        }

        public Task DoWork()
        {
            return Task.Run(() =>
            {
                Program(); //the previous Run() referes to threads 
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

        public void Program()
        {

            Stopwatch sw = Stopwatch.StartNew(); // make a new stopwatch to take count.


            string[] fileContentsArray = readData(_filename); //Read and load data here into an Array. You cannot chnage an array in c#.

            //Console.Write("Original list word count:  ", fileContentsArray.Count()); // check word count in original file


            List<string> modifiedWords = modifiedWordList(fileContentsArray); //checking loaded data word for word - so they good.
            _dictionary = uniqueWordDictionary(modifiedWords); // prooning the modifiedWordList word with BIT stuff to remove doublicates , anagrams etc.
            _solutions = new List<string>(); //making new string 
            recurciveFiveWordSet(_dictionary.Keys.ToArray(), 0, 0, new List<string>()); // make 5 word sets as a string and pass them to solutions.

            sw.Stop();
            _runtime = sw.Elapsed.TotalMilliseconds;

        }
        //loading the  data from the passed file, then just the data file we are interested in this passes the values down to function that checks if the words are okay.
        public string[] readData(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File found");
                try
                {
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

        // this makes a set of 5 words and adds it to a list called solutions as one string. 
        private void recurciveFiveWordSet(int[] keys, int index, int mask, List<string> words)
        {
            for (int i = index; i < keys.Length; i++)
            {
                if ((keys[i] & mask) == 0) //check unique letters
                {
                    var newList = new List<string>(words);
                    newList.Add(_dictionary[keys[i]]);
                    if (newList.Count == _wordCount)
                    {
                        _solutions.Add(string.Join(' ', newList)); // makes the 5 words into one string... no more list of lists
                    }
                    else
                    {
                        recurciveFiveWordSet(keys, i + 1, mask | keys[i], newList);
                    }
                    
                }
                if (mask == 0)
                {
                    OnUpdateSearchIndex(i * 100 / keys.Length);
                }
            }


        }

        //basic test if word is there and it is 5 characters long.
        public bool isWordValid(string word)
        {
            return word.Length == _wordLength ? true : false;

       
        }

        //This is to see if the given word does not repeat characters.
        public List<string> modifiedWordList(string[] fileContentsArray)
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
        private Dictionary<int, string> uniqueWordDictionary(List<string> modifiedWords)
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
