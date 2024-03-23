using LAB3;
using System.Net;


namespace GUI
{
    public partial class Form1 : Form
    {

        APITest api = new APITest();

        public Form1()
        {
            InitializeComponent();
            WebClient client = new WebClient();
            /* while (true)
             {
                 try
                 {
                     string result = client.DownloadString("http://www.google.com");
                     Debug.WriteLine("Aplikacja ma dostêp do Internetu.");

                 }
                 catch (WebException)
                 {
                     Debug.WriteLine("Aplikacja nie mo¿e uzyskaæ dostêpu do Internetu.");
                 }
             }*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pogoda context = new Pogoda();
            richTextBox1.Text = "";
            List<PoorDanePogodowe> tmp = new List<PoorDanePogodowe>();
            float prog;

            if (textBoxProg.Text != "" && float.TryParse(textBoxProg.Text, out prog) && (radioButton_fitr_gorn.Checked == true || radioButton_filtr_dol.Checked == true))
            {

                if (radioButton_sort_ros.Checked == true)
                {
                    if (radioButton_filtr_dol.Checked == true)
                    {
                        tmp = context.FiltrByTempHigher_and_SortByTempAsc(prog);
                    }
                    else if (radioButton_fitr_gorn.Checked == true)
                    {
                        tmp = context.FiltrByTempLower_and_SortByTempAsc(prog);
                    }

                }
                else if (radioButton_sort_mal.Checked == true)
                {
                    if (radioButton_filtr_dol.Checked == true)
                    {
                        tmp = context.FiltrByTempHigher_and_SortByTempDesc(prog);
                    }
                    else if (radioButton_fitr_gorn.Checked == true)
                    {
                        tmp = context.FiltrByTempLower_and_SortByTempDesc(prog);
                    }

                }

                else if (radioButton_filtr_dol.Checked == true && radioButton_sort_ros.Checked == false && radioButton_sort_mal.Checked == false)
                {

                    tmp = context.FiltrByTempHigher(prog);
                }
                else if (radioButton_fitr_gorn.Checked == true && radioButton_sort_ros.Checked == false && radioButton_sort_mal.Checked == false)
                {
                    tmp = context.FiltrByTempLower(prog);
                }


            }
            else
            {


                if (radioButton_sort_ros.Checked == true && radioButton_fitr_gorn.Checked == false && radioButton_filtr_dol.Checked == false)
                {

                    tmp = context.SortByTempAsc();

                }
                else if (radioButton_sort_mal.Checked == true && radioButton_fitr_gorn.Checked == false && radioButton_filtr_dol.Checked == false)
                {
                    tmp = context.SortByTempDesc();
                }
                else
                {
                    tmp = context.BazaPogodowa.ToList();
                }
            }

            foreach (var item in tmp)
            {
                

            }


                richTextBox1.Text += "Oto wszystkie elementy w bazie:\n";

            foreach (var item in tmp)
            {
                richTextBox1.Text += item.ToString();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Pogoda context = new Pogoda();
            context.WyczyscBazeDanych();
            richTextBox1.Text += "WYCZYSZCZONO POMYSLNIE CALA BAZE DANYCH\n";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string city = textBoxMiasto.Text;


            await api.HandlerDoApiGUI(city);
            richTextBox1.Text = "";
            richTextBox1.Text += api.output;
            api.output = "";
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxProg.Text != "")
            {
                int wyjscie;
                if (int.TryParse(textBoxProg.Text, out wyjscie))
                {
                    textBoxProg.BackColor = Color.LightGreen;
                }
                else
                {
                    textBoxProg.BackColor = Color.LightCoral;
                }
            }
            else
            {
                textBoxProg.BackColor = Color.White;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        
    }
}
