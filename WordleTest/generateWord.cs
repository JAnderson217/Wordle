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
            List<string> allLinesText = new List<string>();
            foreach (string line in System.IO.File.ReadLines(@"dictionary.txt"))
            {
                if (line.Length == 5)
                {
                    allLinesText.Add(line);
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
