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
        [Test]
        public void guessWordCorrectly()
        {
            //guess correct word
            WordleTest.Form1 form1 = new WordleTest.Form1();
            form1.letters[0][0] = " ";
            Form1 newForm = new Form1();
            newForm.letters[0][0] = "a";
            Console.WriteLine(newForm.wordToGuess);
            Assert.That(newForm.wordToGuess == "hello");
        }
    }
}
