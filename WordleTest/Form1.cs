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
            
            for (int i=0; i<5; i++)
            {
                //colour change rows to red, green, yellow
                letters[i, 0].BackColor = Color.Red;
                letters[i, 1].BackColor = Color.Green;
                letters[i, 2].BackColor = Color.LightGoldenrodYellow; 
                //lock row after guess
                letters[i,0].ReadOnly = true;
            }   
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
