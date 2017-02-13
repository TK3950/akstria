using System.Reflection;

namespace Project2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.consonantsBox1 = new System.Windows.Forms.TextBox();
            this.vowelsBox1 = new System.Windows.Forms.TextBox();
            this.digramsBox1 = new System.Windows.Forms.TextBox();
            this.trigramsBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.diphthongsBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.trackBar1_v = new System.Windows.Forms.TrackBar();
            this.trackBar2_cv = new System.Windows.Forms.TrackBar();
            this.trackBar3_vc = new System.Windows.Forms.TrackBar();
            this.trackBar4_cvc = new System.Windows.Forms.TrackBar();
            this.trackBar5_vd = new System.Windows.Forms.TrackBar();
            this.trackBar6_dv = new System.Windows.Forms.TrackBar();
            this.trackBar10_dic = new System.Windows.Forms.TrackBar();
            this.trackBar11_cdic = new System.Windows.Forms.TrackBar();
            this.trackBar12_cdi = new System.Windows.Forms.TrackBar();
            this.trackBar13_vt = new System.Windows.Forms.TrackBar();
            this.trackBar14_tv = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2_cv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3_vc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4_cvc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5_vd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6_dv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10_dic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11_cdic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar12_cdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar13_vt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar14_tv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(363, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(505, 287);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // consonantsBox1
            // 
            this.consonantsBox1.Location = new System.Drawing.Point(84, 51);
            this.consonantsBox1.Name = "consonantsBox1";
            this.consonantsBox1.Size = new System.Drawing.Size(262, 20);
            this.consonantsBox1.TabIndex = 1;
            this.consonantsBox1.Text = "bcdfghjklmnprstvwxyz";
            // 
            // vowelsBox1
            // 
            this.vowelsBox1.Location = new System.Drawing.Point(84, 93);
            this.vowelsBox1.Name = "vowelsBox1";
            this.vowelsBox1.Size = new System.Drawing.Size(262, 20);
            this.vowelsBox1.TabIndex = 2;
            this.vowelsBox1.Text = "aeiou";
            // 
            // digramsBox1
            // 
            this.digramsBox1.Location = new System.Drawing.Point(84, 144);
            this.digramsBox1.Name = "digramsBox1";
            this.digramsBox1.Size = new System.Drawing.Size(262, 20);
            this.digramsBox1.TabIndex = 3;
            this.digramsBox1.Text = "st,ch,sh,pl,br,qu,ck,th,";
            // 
            // trigramsBox1
            // 
            this.trigramsBox1.Location = new System.Drawing.Point(84, 195);
            this.trigramsBox1.Name = "trigramsBox1";
            this.trigramsBox1.Size = new System.Drawing.Size(262, 20);
            this.trigramsBox1.TabIndex = 4;
            this.trigramsBox1.Text = "sch,str,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Consonants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vowels";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Digrams";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trigrams";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Diphthongs";
            // 
            // diphthongsBox1
            // 
            this.diphthongsBox1.Location = new System.Drawing.Point(84, 248);
            this.diphthongsBox1.Name = "diphthongsBox1";
            this.diphthongsBox1.Size = new System.Drawing.Size(262, 20);
            this.diphthongsBox1.TabIndex = 9;
            this.diphthongsBox1.Text = "ae,oi,ei,ie,ou,au,ai,oe,";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(84, 297);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(84, 326);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown2.TabIndex = 12;
            this.numericUpDown2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "# of syllables";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "# of words";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Element";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(727, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trackBar1_v
            // 
            this.trackBar1_v.LargeChange = 1;
            this.trackBar1_v.Location = new System.Drawing.Point(12, 380);
            this.trackBar1_v.Maximum = 100;
            this.trackBar1_v.Name = "trackBar1_v";
            this.trackBar1_v.Size = new System.Drawing.Size(104, 45);
            this.trackBar1_v.TabIndex = 32;
            this.trackBar1_v.Value = 30;
            // 
            // trackBar2_cv
            // 
            this.trackBar2_cv.Location = new System.Drawing.Point(122, 380);
            this.trackBar2_cv.Maximum = 100;
            this.trackBar2_cv.Name = "trackBar2_cv";
            this.trackBar2_cv.Size = new System.Drawing.Size(104, 45);
            this.trackBar2_cv.TabIndex = 33;
            this.trackBar2_cv.Value = 35;
            // 
            // trackBar3_vc
            // 
            this.trackBar3_vc.Location = new System.Drawing.Point(232, 380);
            this.trackBar3_vc.Maximum = 100;
            this.trackBar3_vc.Name = "trackBar3_vc";
            this.trackBar3_vc.Size = new System.Drawing.Size(104, 45);
            this.trackBar3_vc.TabIndex = 34;
            this.trackBar3_vc.Value = 35;
            // 
            // trackBar4_cvc
            // 
            this.trackBar4_cvc.Location = new System.Drawing.Point(342, 380);
            this.trackBar4_cvc.Maximum = 100;
            this.trackBar4_cvc.Name = "trackBar4_cvc";
            this.trackBar4_cvc.Size = new System.Drawing.Size(104, 45);
            this.trackBar4_cvc.TabIndex = 35;
            this.trackBar4_cvc.Value = 45;
            // 
            // trackBar5_vd
            // 
            this.trackBar5_vd.Location = new System.Drawing.Point(452, 380);
            this.trackBar5_vd.Maximum = 100;
            this.trackBar5_vd.Name = "trackBar5_vd";
            this.trackBar5_vd.Size = new System.Drawing.Size(104, 45);
            this.trackBar5_vd.TabIndex = 36;
            this.trackBar5_vd.Value = 15;
            // 
            // trackBar6_dv
            // 
            this.trackBar6_dv.Location = new System.Drawing.Point(562, 380);
            this.trackBar6_dv.Maximum = 100;
            this.trackBar6_dv.Name = "trackBar6_dv";
            this.trackBar6_dv.Size = new System.Drawing.Size(104, 45);
            this.trackBar6_dv.TabIndex = 37;
            this.trackBar6_dv.Value = 15;
            // 
            // trackBar10_dic
            // 
            this.trackBar10_dic.Location = new System.Drawing.Point(452, 467);
            this.trackBar10_dic.Maximum = 100;
            this.trackBar10_dic.Name = "trackBar10_dic";
            this.trackBar10_dic.Size = new System.Drawing.Size(104, 45);
            this.trackBar10_dic.TabIndex = 43;
            this.trackBar10_dic.Value = 10;
            // 
            // trackBar11_cdic
            // 
            this.trackBar11_cdic.Location = new System.Drawing.Point(342, 467);
            this.trackBar11_cdic.Maximum = 100;
            this.trackBar11_cdic.Name = "trackBar11_cdic";
            this.trackBar11_cdic.Size = new System.Drawing.Size(104, 45);
            this.trackBar11_cdic.TabIndex = 42;
            this.trackBar11_cdic.Value = 5;
            // 
            // trackBar12_cdi
            // 
            this.trackBar12_cdi.Location = new System.Drawing.Point(232, 467);
            this.trackBar12_cdi.Maximum = 100;
            this.trackBar12_cdi.Name = "trackBar12_cdi";
            this.trackBar12_cdi.Size = new System.Drawing.Size(104, 45);
            this.trackBar12_cdi.TabIndex = 41;
            this.trackBar12_cdi.Value = 10;
            // 
            // trackBar13_vt
            // 
            this.trackBar13_vt.Location = new System.Drawing.Point(122, 467);
            this.trackBar13_vt.Maximum = 100;
            this.trackBar13_vt.Name = "trackBar13_vt";
            this.trackBar13_vt.Size = new System.Drawing.Size(104, 45);
            this.trackBar13_vt.TabIndex = 40;
            this.trackBar13_vt.Value = 10;
            // 
            // trackBar14_tv
            // 
            this.trackBar14_tv.Location = new System.Drawing.Point(12, 467);
            this.trackBar14_tv.Maximum = 100;
            this.trackBar14_tv.Name = "trackBar14_tv";
            this.trackBar14_tv.Size = new System.Drawing.Size(104, 45);
            this.trackBar14_tv.TabIndex = 39;
            this.trackBar14_tv.Value = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "CV";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "VC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(380, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "CVC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(493, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "VD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(603, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "DV";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 451);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "TV";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(164, 451);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "VT";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(268, 451);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 54;
            this.label17.Text = "C(vv)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(375, 451);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 13);
            this.label18.TabIndex = 55;
            this.label18.Text = "C(vv)C";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(488, 451);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(32, 13);
            this.label19.TabIndex = 56;
            this.label19.Text = "(vv)C";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 57;
            this.button3.Text = "Test RNG";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(545, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 58;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 59;
            this.textBox1.Text = ",";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(84, 20);
            this.textBox2.TabIndex = 60;
            this.textBox2.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(162, 330);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 13);
            this.label20.TabIndex = 61;
            this.label20.Text = "Separate Words";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(162, 301);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(94, 13);
            this.label21.TabIndex = 62;
            this.label21.Text = "Separate Syllables";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 63;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 534);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.trackBar10_dic);
            this.Controls.Add(this.trackBar11_cdic);
            this.Controls.Add(this.trackBar12_cdi);
            this.Controls.Add(this.trackBar13_vt);
            this.Controls.Add(this.trackBar14_tv);
            this.Controls.Add(this.trackBar6_dv);
            this.Controls.Add(this.trackBar5_vd);
            this.Controls.Add(this.trackBar4_cvc);
            this.Controls.Add(this.trackBar3_vc);
            this.Controls.Add(this.trackBar2_cv);
            this.Controls.Add(this.trackBar1_v);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.diphthongsBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trigramsBox1);
            this.Controls.Add(this.digramsBox1);
            this.Controls.Add(this.vowelsBox1);
            this.Controls.Add(this.consonantsBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = string.Format("Word Generator v{0} (C) Timothy Kersten", Assembly.GetExecutingAssembly().GetName().Version.ToString());
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2_cv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3_vc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4_cvc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5_vd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6_dv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10_dic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11_cdic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar12_cdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar13_vt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar14_tv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox consonantsBox1;
        private System.Windows.Forms.TextBox vowelsBox1;
        private System.Windows.Forms.TextBox digramsBox1;
        private System.Windows.Forms.TextBox trigramsBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox diphthongsBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1_v;
        private System.Windows.Forms.TrackBar trackBar2_cv;
        private System.Windows.Forms.TrackBar trackBar3_vc;
        private System.Windows.Forms.TrackBar trackBar4_cvc;
        private System.Windows.Forms.TrackBar trackBar5_vd;
        private System.Windows.Forms.TrackBar trackBar6_dv;
        private System.Windows.Forms.TrackBar trackBar10_dic;
        private System.Windows.Forms.TrackBar trackBar11_cdic;
        private System.Windows.Forms.TrackBar trackBar12_cdi;
        private System.Windows.Forms.TrackBar trackBar13_vt;
        private System.Windows.Forms.TrackBar trackBar14_tv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}