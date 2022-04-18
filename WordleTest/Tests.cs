using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordleTest;

namespace WordleTests
{
    public class GuessesTest
    {
        //update tests to check MessageBox
        [Test]
        public void guessCorrectWord()
        {
            //check if hasWon variable returns true when correct word is guessed
            Form1 newForm = new Form1();
            string guess = newForm.wordToGuess;
            //fill textboxes with guess
            for (int i = 0; i < 5; i++)
            {
                newForm.letters[i][0].Text = guess[i].ToString();
            }
            newForm.button1_Click(this, new EventArgs());            
            Assert.That(newForm.hasWon == true);
        }
        [Test]
        [TestCase("audio")]
        [TestCase("towns")]
        [TestCase("react")]
        public void guessIncorrectWord(string guess)
        {
            //guesses audio, should return false, however has small chance of returning true
            //update to check MessageBox
            //checks for incorrect guess, and for guesses to be 1 now
            Form1 newForm = new Form1();
            for (int i = 0; i < 5; i++)
            {
                newForm.letters[i][0].Text = guess[i].ToString();
            }
            newForm.button1_Click(this, new EventArgs());
            Assert.That(!newForm.hasWon && newForm.guesses == 1);
        }
        [Test]
        [TestCase("abcde")]
        [TestCase("suga")]
        [TestCase("craz9")]
        public void guessInvalidWord(string guess)
        {
            //guesses invalid word, i.e. not a real word, not a-z, not length of 5
            //update to check MessageBox
            //checks that number of guesses is still 0, and runs isValid method should return false 
            Form1 newForm = new Form1();
            for (int i = 0; i < guess.Length; i++)
            {
                newForm.letters[i][0].Text = guess[i].ToString();
            }
            newForm.button1_Click(this, new EventArgs());
            bool isValid = newForm.check.isValid(newForm.guesses, newForm.letters, guess);
            Assert.That(newForm.guesses == 0 && isValid == false);
        }
    }
}
