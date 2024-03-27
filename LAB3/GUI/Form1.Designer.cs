namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxMiasto = new TextBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            textBoxProg = new TextBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            panel2 = new Panel();
            Brak = new RadioButton();
            radioButton_filtr_dol = new RadioButton();
            radioButton_fitr_gorn = new RadioButton();
            panel1 = new Panel();
            radioButton1 = new RadioButton();
            radioButton_sort_ros = new RadioButton();
            radioButton_sort_mal = new RadioButton();
            button4 = new Button();
            process1 = new System.Diagnostics.Process();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxMiasto
            // 
            textBoxMiasto.Location = new Point(195, 367);
            textBoxMiasto.Name = "textBoxMiasto";
            textBoxMiasto.Size = new Size(125, 27);
            textBoxMiasto.TabIndex = 0;
            textBoxMiasto.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 344);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Miasto:";
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1019, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(482, 369);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(195, 409);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 3;
            button1.Text = "Sprawdź miasto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(6, 90);
            button2.Name = "button2";
            button2.Size = new Size(138, 29);
            button2.TabIndex = 4;
            button2.Text = "Wyczysc baze";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(6, 40);
            button3.Name = "button3";
            button3.Size = new Size(138, 29);
            button3.TabIndex = 5;
            button3.Text = "Wyswietl wszystko";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxProg);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(41, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 182);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Opcje dla bazy danych";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 13);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 11;
            label4.Text = "Posortuj:";
            // 
            // textBoxProg
            // 
            textBoxProg.Location = new Point(537, 140);
            textBoxProg.Name = "textBoxProg";
            textBoxProg.Size = new Size(73, 27);
            textBoxProg.TabIndex = 10;
            textBoxProg.TextAlign = HorizontalAlignment.Center;
            textBoxProg.TextChanged += textBox1_TextChanged_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 152);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(166, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Filtrowanie po dacie";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 13);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 9;
            label2.Text = "Dodaj:";
            // 
            // panel2
            // 
            panel2.Controls.Add(Brak);
            panel2.Controls.Add(radioButton_filtr_dol);
            panel2.Controls.Add(radioButton_fitr_gorn);
            panel2.Location = new Point(488, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 98);
            panel2.TabIndex = 7;
            // 
            // Brak
            // 
            Brak.AutoSize = true;
            Brak.Checked = true;
            Brak.Location = new Point(11, 59);
            Brak.Name = "Brak";
            Brak.Size = new Size(59, 24);
            Brak.TabIndex = 2;
            Brak.TabStop = true;
            Brak.Text = "Brak";
            Brak.UseVisualStyleBackColor = true;
            // 
            // radioButton_filtr_dol
            // 
            radioButton_filtr_dol.AutoSize = true;
            radioButton_filtr_dol.Location = new Point(11, 35);
            radioButton_filtr_dol.Name = "radioButton_filtr_dol";
            radioButton_filtr_dol.Size = new Size(144, 24);
            radioButton_filtr_dol.TabIndex = 1;
            radioButton_filtr_dol.Text = "Dolny próg temp";
            radioButton_filtr_dol.UseVisualStyleBackColor = true;
            // 
            // radioButton_fitr_gorn
            // 
            radioButton_fitr_gorn.AutoSize = true;
            radioButton_fitr_gorn.Location = new Point(11, 9);
            radioButton_fitr_gorn.Name = "radioButton_fitr_gorn";
            radioButton_fitr_gorn.Size = new Size(144, 24);
            radioButton_fitr_gorn.TabIndex = 0;
            radioButton_fitr_gorn.Text = "Górny próg temp";
            radioButton_fitr_gorn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton_sort_ros);
            panel1.Controls.Add(radioButton_sort_mal);
            panel1.Location = new Point(179, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 98);
            panel1.TabIndex = 8;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(4, 65);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Brak";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton_sort_ros
            // 
            radioButton_sort_ros.AutoSize = true;
            radioButton_sort_ros.Location = new Point(4, 35);
            radioButton_sort_ros.Name = "radioButton_sort_ros";
            radioButton_sort_ros.Size = new Size(243, 24);
            radioButton_sort_ros.TabIndex = 7;
            radioButton_sort_ros.Text = "Posortuj wynik rosnaco wg temp";
            radioButton_sort_ros.UseVisualStyleBackColor = true;
            // 
            // radioButton_sort_mal
            // 
            radioButton_sort_mal.AutoSize = true;
            radioButton_sort_mal.Location = new Point(4, 5);
            radioButton_sort_mal.Name = "radioButton_sort_mal";
            radioButton_sort_mal.Size = new Size(252, 24);
            radioButton_sort_mal.TabIndex = 6;
            radioButton_sort_mal.Text = "Posortuj wynik malejaco wg temp";
            radioButton_sort_mal.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(1205, 387);
            button4.Name = "button4";
            button4.Size = new Size(164, 29);
            button4.TabIndex = 7;
            button4.Text = "Wyczyść okno";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(41, 261);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(289, 27);
            dateTimePicker1.TabIndex = 8;
            dateTimePicker1.Tag = "";
            dateTimePicker1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 238);
            label3.Name = "label3";
            label3.Size = new Size(338, 20);
            label3.TabIndex = 9;
            label3.Text = "Wprowadź datę, z której będą wyświetlane wyniki";
            label3.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ikonki;
            pictureBox1.Location = new Point(529, 238);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(484, 242);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1513, 516);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(textBoxMiasto);
            Name = "Form1";
            Text = "Aplikacja Pogodowa";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMiasto;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private RadioButton radioButton_sort_mal;
        private RadioButton radioButton_sort_ros;
        private Panel panel1;
        private Panel panel2;
        private RadioButton radioButton_filtr_dol;
        private RadioButton radioButton_fitr_gorn;
        private Label label2;
        private TextBox textBoxProg;
        private Button button4;
        private RadioButton Brak;
        private RadioButton radioButton1;
        private System.Diagnostics.Process process1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
