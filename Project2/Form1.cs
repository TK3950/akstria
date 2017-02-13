using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project2
{
    public partial class Form1 : Form
    {

        public int uptick;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string[] allChars = new string[textBox1.TextLength];
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                // create array for all chars of textbox
                allChars[i] = textBox1.Text[i].ToString();
            }
            createWords(allChars);

        }

        public void createWords(string[] letters)
        {
            int wordlength = Convert.ToInt32(numericUpDown1.Value);
            int numberofwords = Convert.ToInt32(numericUpDown2.Value);
            string word = "";

            string[] words = new string[numberofwords];

            for (int i = 0; i < numberofwords; i++)
            {
                for (int j = 0; j < wordlength; j++ )
                {
                    
                    int k = 0;
                    for (k=getSeed(letters.Length); k >= letters.Length; k=(k/7))
                    {
                        
                        richTextBox1.Update();
                    }
                    
                    

                    


                }
                richTextBox1.Text += word + " , ";
                word = "";
                richTextBox1.Update();
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            uptick++;
        }

        public int getSeed(int max)
        {
            System.Threading.Thread.Sleep(40);
            Random rng = new Random();
            return rng.Next(0, max);
        }
    }
}


