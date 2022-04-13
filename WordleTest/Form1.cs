using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleTest
{
    public partial class Form1 : Form
    {
        public TextBox[,] letters = new TextBox[5,5];
        public string wordToGuess;
        public Form1()
        {   
            InitializeComponent();
            textGrid();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            //updateColours, first row one yellow, second 1 green 2 yellow, third all green
            updateColours(0, new int[] {0,2,0,0,0});
            updateColours(1, new int[] { 1,0,2,2,0 });
            updateColours(2, new int[] { 1,1,1,1,1 });  
        }
        public void textGrid()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    letters[i, j] = new TextBox();
                    //letters[i,j] = new System.Windows.Forms.TextBox();
                    letters[i, j].SuspendLayout();
                    // 
                    // textBox1
                    // 
                    letters[i, j].Location = new System.Drawing.Point(60 + (i * 26), 49 + (j * 26));
                    letters[i, j].MaxLength = 1;
                    letters[i, j].Size = new System.Drawing.Size(25, 22);
                    letters[i, j].TabIndex = 0;
                    this.Controls.Add(letters[i, j]);
                }
            }
        }

        public void updateColours(int guess, int[] colours)
        {
            //updates colours, gives current guess and array of which colour to fill
            //loop through colours, change color, 0 leave, 1 green, 2 yellow
            for (int i = 0; i < 5; i++)
            {
                if (colours[i] == 1)
                {
                    letters[i,guess].BackColor = Color.Green;
                }
                else if (colours[i] == 2)
                {
                    letters[i,guess].BackColor = Color.LightGoldenrodYellow;
                }
                //lock row after guess
                letters[i, guess].ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            generateWord randWord = new generateWord();
            wordToGuess = randWord.wordToGuess();
            for (int i = 0; i < 5; i++)
            {
                letters[i, 4].Text = wordToGuess[i].ToString().ToUpper();
            }
        }
    }
}
