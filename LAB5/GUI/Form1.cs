using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private Bitmap? img;
        private Bitmap? negated;
        private Bitmap? gray;
        private Bitmap? edges;
        private Bitmap? mirror;
        private Thread[] threads = new Thread[4];

        private bool shouldStop = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!AreThreadsStopped())
            {
                StopThreads();
            }

            while (!AreThreadsStopped())
            {
                Thread.Sleep(200);
            }

            shouldStop = false;


            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                img = new Bitmap(file);
                pictureBoxNormal.Image = img;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {

            if (img != null && AreThreadsStopped())
            {

                for (int i = 0; i < threads.Length; i++)
                {
                    int it = i;
                    Bitmap bmp = new Bitmap(img);

                    threads[i] = new Thread(() => Przetworz(it, bmp));
                    threads[i].Start();
                }

            }
        }

        public void Przetworz(int it, Bitmap image)
        {   

            switch (it)
            {

                case 0:
                    NegateImage(image);
                    UpdateProgressBar(25);
                    break;



                case 1:
                    Gray(image);
                    UpdateProgressBar(25);
                    break;



                case 2:
                    Mirror(image);
                    UpdateProgressBar(25);
                    break;


                case 3:

                    Edges(image);
                    break;

            }
        }
        private void NegateImage(Bitmap image)
        {
            negated = new Bitmap(image.Width, image.Height);


            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);


                    int red = 255 - pixel.R;
                    int green = 255 - pixel.G;
                    int blue = 255 - pixel.B;


                    negated.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    if (shouldStop)
                    {
                        return;
                    }
                }
            }

            pictureBoxNegated.Image = negated;
        }
        private void Gray(Bitmap image)
        {
            gray = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);


                    int grayscale = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);


                    gray.SetPixel(x, y, Color.FromArgb(grayscale, grayscale, grayscale));
                    if (shouldStop)
                    {
                        return;
                    }
                }
            }

            pictureBoxGray.Image = gray;
        }
        private void Edges(Bitmap image)
        {
            edges = new Bitmap(image.Width, image.Height);


            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);


                    int grayscale = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);


                    edges.SetPixel(x, y, Color.FromArgb(grayscale, grayscale, grayscale));
                    if (shouldStop)
                    {
                        return;
                    }
                }
            }

            UpdateProgressBar(10);

            for (int y = 1; y < image.Height - 1; y++)
            {
                for (int x = 1; x < image.Width - 1; x++)
                {
                    int gx = 0, gy = 0;

                    gx += image.GetPixel(x - 1, y - 1).R * -1;
                    gx += image.GetPixel(x - 1, y).R * -2;
                    gx += image.GetPixel(x - 1, y + 1).R * -1;
                    gx += image.GetPixel(x + 1, y - 1).R * 1;
                    gx += image.GetPixel(x + 1, y).R * 2;
                    gx += image.GetPixel(x + 1, y + 1).R * 1;

                    gy += image.GetPixel(x - 1, y - 1).R * -1;
                    gy += image.GetPixel(x, y - 1).R * -2;
                    gy += image.GetPixel(x + 1, y - 1).R * -1;
                    gy += image.GetPixel(x - 1, y + 1).R * 1;
                    gy += image.GetPixel(x, y + 1).R * 2;
                    gy += image.GetPixel(x + 1, y + 1).R * 1;

                    int gradient = (int)Math.Sqrt(gx * gx + gy * gy);
                    gradient = Math.Min(255, gradient);


                    edges.SetPixel(x, y, Color.FromArgb(gradient, gradient, gradient));
                    if (shouldStop)
                    {
                        return;
                    }
                }

            }
            UpdateProgressBar(15);

            pictureBoxEdges.Image = edges;
        }


        private void Mirror(Bitmap image)
        {
            mirror = new Bitmap(image.Width, image.Height);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {

                    Color pixel = image.GetPixel(image.Width - x - 1, y);
                    mirror.SetPixel(x, y, pixel);
                    if (shouldStop)
                    {
                        return;
                    }
                }
            }

            pictureBoxMirror.Image = mirror;
        }

        private bool AreThreadsStopped()
        {

            foreach (Thread thread in threads)
            {
                if (thread != null && thread.IsAlive)
                {
                    return false;
                }
            }
            return true;
        }
        private void StopThreads()
        {

            shouldStop = true;
        }
        private void UpdateProgressBar(int value)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value += value));
            }
            else
            {
                progressBar1.Value += value;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }


}


