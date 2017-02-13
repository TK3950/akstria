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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Managing function that calls all other base functions to outline the first layer of program flow.
        /// </summary>
        /// <param name="consonants">An array of all consonant elements</param>
        /// <param name="vowels">An array of all vowel elements</param>
        /// <param name="digrams">An array of all digram elements</param>
        /// <param name="trigrams">An array of all trigram elements</param>
        /// <param name="diphthongs">An array of all diphthong elements</param>
        /// <param name="tbSums">The sum of all syllable weights</param>
        public void createWords(string[] consonants, string[] vowels, string[] digrams, string[] trigrams, string[] diphthongs, int tbSums)
        {
            int wordlength = Convert.ToInt32(numericUpDown2.Value);
            int numberofwords = Convert.ToInt32(numericUpDown1.Value);
            string[] words = new string[numberofwords]; // currently unused, but may be useful for exporting lists of words created
            for (int i = 0; i < numberofwords; i++)
            {
                string word = ""; // word currently being created
                
                for (int j = 0; j < wordlength; j++)
                {
                    word += (getSyllable(consonants, vowels, digrams, trigrams, diphthongs, pickSyllableType(tbSums)));
                   word += textBox2.Text;
                }
                richTextBox1.Text += word + textBox1.Text + " ";
                word = "";
                richTextBox1.Update(); // thread delay prevents items from updating, this forces update
            }
        } // this does the work. called by button click

        /// <summary>
        /// Returns the number of times a substring occurs in a parent string.
        /// </summary>
        /// <param name="parent">The parent string to be searched in</param>
        /// <param name="substring">The substring to be searched for</param>
        /// <returns>Returns the number of times substring occurs in parent</returns>
        public int timesInString(string parent, string substring)
        {
            int occurances = 0;
            for (int i = 0; i < parent.Length; i++)
            {
                if (parent.Substring(i, 1) == substring)
                {
                    occurances++;
                }
            }
            return occurances;
        }  // returns the number of times a string occurs in a larger string

        /// <summary>
        /// Returns a string representing a syllable chosen randomly based on slider values.
        /// </summary>
        /// <param name="consonants">An array of all consonant elements</param>
        /// <param name="vowels">An array of all vowel elements</param>
        /// <param name="digrams">An array of all digram elements</param>
        /// <param name="trigrams">An array of all trigram elements</param>
        /// <param name="diphthongs">An array of all diphthong elements</param>
        /// <param name="syllableType">Integer 1-11 to determine the syllable type</param>
        /// <returns>Returns a complete syllable string</returns>
        public string getSyllable(string[] consonants, string[] vowels, string[] digrams, string[] trigrams, string[] diphthongs, int syllableType)
        {
            string syllable = "";
            // this functions is a little dirty. it mostly the same objects as createWords plus one int syllableType
            switch (syllableType)
            {
                default:
                case 1:
                    // v
                    syllable = vowels[getSeed(vowels.Length)];
                    break;
                case 2:
                    // cv
                    syllable = consonants[getSeed(consonants.Length)] + vowels[getSeed(vowels.Length)];
                    break;
                case 3:
                    // vc
                    syllable = vowels[getSeed(vowels.Length)] + consonants[getSeed(consonants.Length)];
                    break;
                case 4:
                    // cvc
                    syllable = consonants[getSeed(consonants.Length)] + vowels[getSeed(vowels.Length)] + consonants[getSeed(consonants.Length)];
                    break;
                case 5:
                    // VD
                    syllable = vowels[getSeed(vowels.Length)] + digrams[getSeed(digrams.Length)];
                    break;
                case 6:
                    // DV
                    syllable = digrams[getSeed(digrams.Length)] + vowels[getSeed(vowels.Length)];
                    break;
                case 7:
                    // TV
                    syllable = trigrams[getSeed(trigrams.Length)] + vowels[getSeed(vowels.Length)];
                    break;
                case 8:
                    // VT
                    syllable = vowels[getSeed(vowels.Length)] + trigrams[getSeed(trigrams.Length)];
                    break;
                case 9:
                    // Cd
                    syllable = consonants[getSeed(consonants.Length)] + diphthongs[getSeed(diphthongs.Length)];
                    break;
                case 10:
                    // CdC
                    syllable = consonants[getSeed(consonants.Length)] + diphthongs[getSeed(diphthongs.Length)] + consonants[getSeed(consonants.Length)];
                    break;
                case 11:
                    // dC
                    syllable = diphthongs[getSeed(diphthongs.Length)] + consonants[getSeed(consonants.Length)];
                    break;

            }

            return syllable;
        } // creates a syllable based on given characters and selected type.

        /// <summary>
        /// Returns the sum of all 11 sliders values.
        /// </summary>
        /// <returns>Returns the sum of all 11 slider values</returns>
        public int trackBarSums()
        {
            int sum = trackBar1_v.Value;
            sum += trackBar2_cv.Value;
            sum += trackBar3_vc.Value;
            sum += trackBar4_cvc.Value;
            sum += trackBar5_vd.Value;
            sum += trackBar6_dv.Value;
            sum += trackBar10_dic.Value;
            sum += trackBar11_cdic.Value;
            sum += trackBar12_cdi.Value;
            sum += trackBar13_vt.Value;
            sum += trackBar14_tv.Value;
            return sum;
        } // returns the total weight of all trackbars

        /// <summary>
        /// Returns an array of percentages for each syllable.
        /// </summary>
        /// <param name="sum">Sum of all trackbar values.</param>
        /// <returns>An array of values representing the probabilities (out of 100) that a syllable should be selected. Percentages are truncated, not rounded. Gaps resulting from this truncation are managed by defaulted switch statements and exceptions elsewhere in the program.</returns>
        public int[] getProbs(int sum)
        {
            int[] percentages;
            percentages = new int[11];
            percentages[0] = trackBar1_v.Value * 100 / sum;
            percentages[1] = trackBar2_cv.Value * 100 / sum;
            percentages[2] = trackBar3_vc.Value * 100 / sum;
            percentages[3] = trackBar4_cvc.Value * 100 / sum;
            percentages[4] = trackBar5_vd.Value * 100 / sum;
            percentages[5] = trackBar6_dv.Value * 100 / sum;
            percentages[6] = trackBar14_tv.Value * 100 / sum;
            percentages[7] = trackBar13_vt.Value * 100 / sum;
            percentages[8] = trackBar12_cdi.Value * 100 / sum;
            percentages[9] = trackBar11_cdic.Value * 100 / sum;
            percentages[10] = trackBar10_dic.Value * 100 / sum;

            return percentages;
        }

        /// <summary>
        /// Returns a 32-Bit integer representing the selected syllable type.
        /// </summary>
        /// <param name="trackbarSum">The sum of all syllable weights</param>
        /// <returns>An integer value from 1-11 that represents a syllable type.</returns>
        public int pickSyllableType(int trackbarSum)
        {
            /*
             * this has been a painfully fun function to write. Glad I got it so small.
             * getProbs() returns an array of percentages that each syllable type will be chosen
             * selection is a random number from 1 to 100.
             * the for loop executes 11 times - one for each syllable type. local_sum is the sum of
             * all syllable type percentages up to the current. if selection is less than the sum of
             * all types, that is the chosen type, provided the current slider is not set to zero.
             */
            int[] percentages = getProbs(trackbarSum);
            int selection = getSeed(100);

            int local_sum = 0;
            for (int i =0; i<=10; i++)
            {
                local_sum += percentages[i];
                if (selection <= local_sum && percentages[i] != 0)
                {
                    return i + 1;
                }
            }

            return 1;
        } // uses a RNG to pick syllables

        /// <summary>
        /// Returns a 32-bit integer from 0 (inclusive) to max (exclusive).
        /// </summary>
        /// <param name="max">Exclusive maximum value.</param>
        /// <returns>Returns a 32-bit integer from 0 (inclusive) to max (exclusive). This function has a considerable thread delay, designed to increase randomness in successive calls.</returns>
        public int getSeed(int max)
        {
            if (max == 0)
            {
                return 1; // lazy exception
            }
            System.Threading.Thread.Sleep(DateTime.Now.Millisecond%50 + 40);
            Random rng = new Random();
            //  .Next(min,max) is exclusive on max.
            return Convert.ToInt32(rng.Next(0, max)); // we like using integers. create another function if other types are needed.
        } // returns an integer between 0 and max

        /// <summary>
        /// Called on button click, this function first creates the element arrays and passes them into createWords.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            string[] consonants = new string[consonantsBox1.TextLength];
            for (int i = 0; i < consonantsBox1.TextLength; i++)
            {
                consonants[i] = consonantsBox1.Text[i].ToString();
            }

            string[] vowels = new string[vowelsBox1.TextLength];
            for (int i = 0; i < vowelsBox1.TextLength; i++)
            {
                vowels[i] = vowelsBox1.Text[i].ToString();
            }

            string[] digrams = new string[timesInString(digramsBox1.Text, ",")]; // extra functions, but less dirty than inline math.
            {
                int iterator = 0; // iterator is reset after each multi-character element is finished processing
                for (int i = 0; i < digramsBox1.TextLength; i++)
                {
                    if (digramsBox1.Text[i].ToString() == ",")
                    {
                        digrams[iterator] = digramsBox1.Text[i - 2].ToString() + digramsBox1.Text[i - 1].ToString();
                        iterator++;
                    }
                }
            }

            string[] trigrams = new string[timesInString(trigramsBox1.Text, ",")];
            {
                int iterator = 0;
                for (int i = 0; i < trigramsBox1.TextLength; i++)
                {
                    if (trigramsBox1.Text[i].ToString() == ",")
                    {
                        trigrams[iterator] = trigramsBox1.Text[i - 3].ToString() + trigramsBox1.Text[i - 2].ToString() + trigramsBox1.Text[i - 1].ToString();
                        iterator++;
                    }
                }
            }

            string[] diphthongs = new string[timesInString(diphthongsBox1.Text, ",")];
            {
                int iterator = 0;
                for (int i = 0; i < digramsBox1.TextLength; i++)
                {
                    if (diphthongsBox1.Text[i].ToString() == ",")
                    {
                        diphthongs[iterator] = diphthongsBox1.Text[i - 2].ToString() + diphthongsBox1.Text[i - 1].ToString();
                        iterator++;
                    }
                }
            }
            createWords(consonants, vowels, digrams, trigrams, diphthongs, trackBarSums());
        } // (Dirty - move/clean filtering out) filters textboxes and sends strings to createWords

        /// <summary>
        /// Clears all text from rich text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Update();
        } // clears all text from text box

        /// <summary>
        /// Show save file dialog and save the contents of the rich text box to a .txt file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = "*.txt";
            saveFileDialog1.Filter = "Text Documents|*.txt";
            saveFileDialog1.CheckPathExists = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
            

        } // save contents of text box to file

        /// <summary>
        /// Tasks to be run when the program first starts (such as a prompt to view help).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            // items to be done on loading
            // currently empty, but I'm keeping it because it might become useful.
        } // on load functions

        /// <summary>
        /// Show the About Box for this program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        } // open about box

        /// <summary>
        /// Show the help information for this program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help1 help = new Help1();
            help.Show();
        } // open help form

        /// <summary>
        /// Test the random number generator to ensure it is working properly.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            trackBar1_v.Value = 0;
            trackBar2_cv.Value = 0;
            trackBar3_vc.Value = 0;
            trackBar4_cvc.Value = 0;
            trackBar5_vd.Value = 0;
            trackBar6_dv.Value = 0;
            trackBar14_tv.Value = 0;
            trackBar13_vt.Value = 0;
            trackBar12_cdi.Value = 0;
            trackBar11_cdic.Value = 0;
            trackBar10_dic.Value = 0;

            for (int i = 0; i < 400; i++)
            {

                switch (getSeed(11) + 1)
                {
                    case 1:
                        trackBar1_v.Value++;
                        break;
                    case 2:
                        trackBar2_cv.Value++;
                        break;
                    case 3:
                        trackBar3_vc.Value++;
                        break;
                    case 4:
                        trackBar4_cvc.Value++;
                        break;
                    case 5:
                        trackBar5_vd.Value++;
                        break;
                    case 6:
                        trackBar6_dv.Value++;
                        break;
                    case 7:
                        trackBar14_tv.Value++;
                        break;
                    case 8:
                        trackBar13_vt.Value++;
                        break;
                    case 9:
                        trackBar12_cdi.Value++;
                        break;
                    case 10:
                        trackBar11_cdic.Value++;
                        break;
                    case 11:
                        trackBar10_dic.Value++;
                        break;
                }
            }

            richTextBox1.Text += trackBar1_v.Value.ToString() + "\n";
            richTextBox1.Text += trackBar2_cv.Value.ToString() + "\n";
            richTextBox1.Text += trackBar3_vc.Value.ToString() + "\n";
            richTextBox1.Text += trackBar4_cvc.Value.ToString() + "\n";
            richTextBox1.Text += trackBar5_vd.Value.ToString() + "\n";
            richTextBox1.Text += trackBar6_dv.Value.ToString() + "\n";
            richTextBox1.Text += trackBar14_tv.Value.ToString() + "\n";
            richTextBox1.Text += trackBar13_vt.Value.ToString() + "\n";
            richTextBox1.Text += trackBar12_cdi.Value.ToString() + "\n";
            richTextBox1.Text += trackBar11_cdic.Value.ToString() + "\n";
            richTextBox1.Text += trackBar10_dic.Value.ToString() + "\n";
        } // sample random numbers

    }
}