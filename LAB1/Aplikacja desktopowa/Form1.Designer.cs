namespace Aplikacja_desktopowa
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
            textBox_n = new TextBox();
            textBox_seed = new TextBox();
            button = new Button();
            wyjscie = new RichTextBox();
            textBox_capacity = new TextBox();
            progressBar = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_n
            // 
            textBox_n.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            textBox_n.Location = new Point(12, 63);
            textBox_n.Name = "textBox_n";
            textBox_n.Size = new Size(125, 38);
            textBox_n.TabIndex = 0;
            textBox_n.TextChanged += textbox_n_TextChanged;
            // 
            // textBox_seed
            // 
            textBox_seed.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            textBox_seed.Location = new Point(12, 124);
            textBox_seed.Name = "textBox_seed";
            textBox_seed.Size = new Size(125, 38);
            textBox_seed.TabIndex = 1;
            textBox_seed.TextChanged += textbox_seed_TextChanged;
            // 
            // button
            // 
            button.BackColor = SystemColors.ScrollBar;
            button.Font = new Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button.ForeColor = Color.Firebrick;
            button.Location = new Point(337, 350);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 2;
            button.Text = "OBLICZ";
            button.UseVisualStyleBackColor = false;
            button.Click += button1_Click;
            // 
            // wyjscie
            // 
            wyjscie.BackColor = SystemColors.HighlightText;
            wyjscie.Location = new Point(501, 37);
            wyjscie.Name = "wyjscie";
            wyjscie.Size = new Size(299, 414);
            wyjscie.TabIndex = 3;
            wyjscie.Text = "";
            // 
            // textBox_capacity
            // 
            textBox_capacity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
            textBox_capacity.Location = new Point(12, 190);
            textBox_capacity.Name = "textBox_capacity";
            textBox_capacity.Size = new Size(125, 38);
            textBox_capacity.TabIndex = 4;
            textBox_capacity.TextChanged += textbox_capacity_TextChanged;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 350);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(278, 29);
            progressBar.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 37);
            label1.Name = "label1";
            label1.Size = new Size(189, 20);
            label1.TabIndex = 7;
            label1.Text = "Podaj liczbe elementow (n)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 101);
            label2.Name = "label2";
            label2.Size = new Size(302, 20);
            label2.TabIndex = 8;
            label2.Text = "Podaj liczbe do generatora RANDOM (seed)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 165);
            label3.Name = "label3";
            label3.Size = new Size(247, 20);
            label3.TabIndex = 9;
            label3.Text = "Podaj pojemnosc plecaka (capacity)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 327);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 10;
            label4.Text = "Postęp";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(635, 14);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 11;
            label5.Text = "Wyjscie";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pobrane;
            pictureBox1.Location = new Point(337, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 234);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(275, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Czy sortować przedmioty w plecaku?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar);
            Controls.Add(textBox_capacity);
            Controls.Add(wyjscie);
            Controls.Add(button);
            Controls.Add(textBox_seed);
            Controls.Add(textBox_n);
            Name = "Form1";
            Text = "Problem plecakowy";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_n;
        private TextBox textBox_seed;
        private Button button;
        private RichTextBox wyjscie;
        private TextBox textBox_capacity;
        private ProgressBar progressBar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
    }
}
