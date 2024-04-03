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
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBoxNormal = new PictureBox();
            button2 = new Button();
            pictureBoxNegated = new PictureBox();
            pictureBoxMirror = new PictureBox();
            pictureBoxEdges = new PictureBox();
            pictureBoxGray = new PictureBox();
            Negatyw = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNormal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNegated).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMirror).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdges).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 321);
            button1.Name = "button1";
            button1.Size = new Size(94, 80);
            button1.TabIndex = 0;
            button1.Text = "załaduj zdjęcie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxNormal
            // 
            pictureBoxNormal.Location = new Point(12, 12);
            pictureBoxNormal.Name = "pictureBoxNormal";
            pictureBoxNormal.Size = new Size(302, 303);
            pictureBoxNormal.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNormal.TabIndex = 1;
            pictureBoxNormal.TabStop = false;
            pictureBoxNormal.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(220, 321);
            button2.Name = "button2";
            button2.Size = new Size(94, 80);
            button2.TabIndex = 2;
            button2.Text = "przetwórz zdjęcie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBoxNegated
            // 
            pictureBoxNegated.Location = new Point(377, 25);
            pictureBoxNegated.Name = "pictureBoxNegated";
            pictureBoxNegated.Size = new Size(172, 153);
            pictureBoxNegated.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNegated.TabIndex = 3;
            pictureBoxNegated.TabStop = false;
            pictureBoxNegated.Tag = "";
            // 
            // pictureBoxMirror
            // 
            pictureBoxMirror.Location = new Point(377, 218);
            pictureBoxMirror.Name = "pictureBoxMirror";
            pictureBoxMirror.Size = new Size(172, 153);
            pictureBoxMirror.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMirror.TabIndex = 4;
            pictureBoxMirror.TabStop = false;
            // 
            // pictureBoxEdges
            // 
            pictureBoxEdges.Location = new Point(600, 25);
            pictureBoxEdges.Name = "pictureBoxEdges";
            pictureBoxEdges.Size = new Size(172, 153);
            pictureBoxEdges.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEdges.TabIndex = 5;
            pictureBoxEdges.TabStop = false;
            // 
            // pictureBoxGray
            // 
            pictureBoxGray.Location = new Point(600, 218);
            pictureBoxGray.Name = "pictureBoxGray";
            pictureBoxGray.Size = new Size(172, 153);
            pictureBoxGray.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGray.TabIndex = 6;
            pictureBoxGray.TabStop = false;
            // 
            // Negatyw
            // 
            Negatyw.AutoSize = true;
            Negatyw.Location = new Point(435, 181);
            Negatyw.Name = "Negatyw";
            Negatyw.Size = new Size(68, 20);
            Negatyw.TabIndex = 7;
            Negatyw.Text = "Negatyw";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(618, 181);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 8;
            label1.Text = "Wykrywanie krawędzi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 374);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 9;
            label2.Text = "Odbicie lustrzane";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(618, 374);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 10;
            label3.Text = "Odcienie szarości";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 409);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 29);
            progressBar1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Negatyw);
            Controls.Add(pictureBoxGray);
            Controls.Add(pictureBoxEdges);
            Controls.Add(pictureBoxMirror);
            Controls.Add(pictureBoxNegated);
            Controls.Add(button2);
            Controls.Add(pictureBoxNormal);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Przetwarzanie obrazów";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxNormal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNegated).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMirror).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEdges).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBoxNormal;
        private Button button2;
        private PictureBox pictureBoxNegated;
        private PictureBox pictureBoxMirror;
        private PictureBox pictureBoxEdges;
        private PictureBox pictureBoxGray;
        private Label Negatyw;
        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
    }
}
