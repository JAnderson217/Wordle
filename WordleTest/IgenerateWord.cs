using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleTest
{
    internal interface IgenerateWord
    {
        List<string> getList();
        string randWord(List<string> words);
        string wordToGuess();
    }
}
