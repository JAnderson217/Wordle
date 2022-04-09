using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleTest
{
    class generateWord
    {
        List<string> getList()
        {
            List<string> allLinesText = System.IO.File.ReadAllLines("dictionary.txt").ToList();
            foreach (string line in allLinesText.ToList())
            {
                if (line.Length != 6)
                {
                    allLinesText.Remove(line);
                }
            }
            return allLinesText;
        }

        string randWord(List<string> words)
        {
            Random random = new Random();
            return words[random.Next(words.Count)];
        }

        public string wordToGuess() { return randWord(getList()); }
    }   
    
}
