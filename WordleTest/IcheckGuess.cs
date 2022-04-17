using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleTest
{
    internal interface IcheckGuess
    {
        int[] updateGrid(int a, TextBox[][] letters, string wordToGuess);
        bool isValid(int a, TextBox[][] letters, string wordToGuess);


    }
}
