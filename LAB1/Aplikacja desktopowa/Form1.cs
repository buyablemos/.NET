
using Konsolowa;

namespace Aplikacja_desktopowa
{
    public partial class Form1 : Form
    {

        bool sort = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wyjscie.ForeColor = Color.Black;
            if (textBox_n.Text != "" && textBox_seed.Text != "" && textBox_capacity.Text != "")
            {
                
                progressBar.Value = 20;
                int n;
                if (!int.TryParse(textBox_n.Text, out n))
                {
                    wyjscie.ForeColor = Color.Red;
                    wyjscie.Text = "Podano z造 parametr n";
                    return;
                }
                if (n<0||n>100000)
                {
                    wyjscie.ForeColor = Color.Red;
                    wyjscie.Text = "Podano z造 parametr n";
                    return;
                }
                progressBar.Value = 40;
                int seed;
                if (!int.TryParse(textBox_seed.Text, out seed))
                {
                    wyjscie.ForeColor = Color.Red;
                    wyjscie.Text = "Podano z造 parametr seed";
                    return;
                }
                
                if (seed < 0 || seed > 100000)
                {
                    wyjscie.ForeColor = Color.Red;
                    wyjscie.Text = "Podano z造 parametr seed";
                    return;
                }
                progressBar.Value = 60;
                int capacity;
                if (!int.TryParse(textBox_capacity.Text, out capacity))
                {
                    wyjscie.ForeColor = Color.Red;
                    wyjscie.Text = "Podano z造 parametr capacity";
                    return;
                }
                if (capacity < 0 || capacity > 100000)
                {
                    wyjscie.ForeColor = Color.Red;
                    wyjscie.Text = "Podano z造 parametr capacity";
                    return;
                }
                progressBar.Value = 80;

                Problem plecak = new Problem(n, seed);
                progressBar.Value = 90;
                Result wynik = plecak.Solve(capacity, this.sort);
                progressBar.Value = 100;
                wyjscie.Text = wynik.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.sort == false)
            {
                this.sort = true;
            }
            else
            {
                this.sort = false;
            }
        }

        private void textbox_n_TextChanged(object sender, EventArgs e)

        {
            if (textBox_n.Text != "") {
                int wyjscie;
                if (int.TryParse(textBox_n.Text, out wyjscie))
                {
                    textBox_n.BackColor = Color.LightGreen;
                }
                else
                {
                    textBox_n.BackColor = Color.LightCoral;
                }
            }
            else
            {
                textBox_n.BackColor = Color.White;
            }
        }
        private void textbox_seed_TextChanged(object sender, EventArgs e)

        {
            if (textBox_seed.Text != "")
            {
                int wyjscie;
                if (int.TryParse(textBox_seed.Text, out wyjscie))
                {
                    textBox_seed.BackColor = Color.LightGreen;
                }
                else
                {
                    textBox_seed.BackColor = Color.LightCoral;
                }
            }
            else
            {
                textBox_seed.BackColor = Color.White;
            }
        }
        private void textbox_capacity_TextChanged(object sender, EventArgs e)

        {
            if (textBox_capacity.Text != "")
            {
                int wyjscie;
                if (int.TryParse(textBox_capacity.Text, out wyjscie))
                {
                    textBox_capacity.BackColor = Color.LightGreen;
                }
                else
                {
                    textBox_capacity.BackColor = Color.LightCoral;
                }
            }
            else
            {
                textBox_capacity.BackColor = Color.White;
            }
        }
    }
}
