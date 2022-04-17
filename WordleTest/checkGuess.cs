using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleTest
{
    public class checkGuess : IcheckGuess
    {
        //method to update grid, checks if word is valid, then checks which letters are correct
        public int[] updateGrid(int a, TextBox[][] letters, string wordToGuess)
        {
            if (!isValid(a, letters, wordToGuess))
            {
                return new int[5] { -1, -1, -1, -1 ,-1};
            }
            int[] colours = new int[5] { 0, 0, 0, 0, 0 };
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i][a].Text.ToLower() == wordToGuess[i].ToString().ToLower())
                {
                    colours[i] = 1;
                }
                else if (wordToGuess.ToLower().Contains(letters[i][a].Text.ToLower()))
                {
                    colours[i] = 2;
                }
            }
            return colours;
        }
        public bool isValid(int a, TextBox[][] letters, string wordToGuess)
        {
            //check if guess is valid
            //check if each char is a-z
            for (int i = 0; i < letters.Length; i++)
            {
                if(!Regex.IsMatch(letters[i][a].Text.ToString(), "[a-z]", RegexOptions.IgnoreCase))
                {
                    return false;
                }
            }
            //get guess as string from row
            string guess = "";
            for (int i = 0; i < letters.Length; i++)
            {
                guess += letters[i][a].Text.ToString();
            }
            Console.WriteLine($"guess: {guess}");
            generateWord gen = new generateWord();
            //if guess is not in dictionary, i.e. not a valid word, return false
            if (!gen.getList().Contains(guess.ToLower()))
            {
                return false;
            }
            return true;
        }

    }   
    
}
