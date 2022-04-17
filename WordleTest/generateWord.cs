using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleTest
{
    class generateWord : IgenerateWord
    {
        public List<string> getList()
        {
            //gets list of words from dictionary txt file into List<string>
            List<string> allLinesText = new List<string>();
            foreach (string line in System.IO.File.ReadLines(@"dictionary.txt"))
            {
                //only adds 5 letter words to list
                if (line.Length == 5)
                {
                    allLinesText.Add(line);
                }
            }
            return allLinesText;
        }

        public string randWord(List<string> words)
        {
            //return random word
            Random random = new Random();
            return words[random.Next(words.Count)];
        }
        //returns word to guess
        public string wordToGuess() { return randWord(getList()); }
    }   
    
}
