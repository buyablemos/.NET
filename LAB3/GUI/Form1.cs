using LAB3;
using System.Net;


namespace GUI
{
    public partial class Form1 : Form
    {

        APITest api = new APITest();
        Pogoda context = new Pogoda();
        bool DateFilter = false;
        

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
     
            richTextBox1.Text = "";
            List<PoorDanePogodowe> tmp = new List<PoorDanePogodowe>();
            float prog;

            DateTime dateTimeFilter= dateTimePicker1.Value;

            if (textBoxProg.Text != "" && float.TryParse(textBoxProg.Text, out prog) && (radioButton_fitr_gorn.Checked == true || radioButton_filtr_dol.Checked == true))
            {

                if (radioButton_sort_ros.Checked == true)
                {
                    if (radioButton_filtr_dol.Checked == true)
                    {
                        tmp = context.FiltrByTempHigher_and_SortByTempAsc(prog,DateFilter,dateTimeFilter);
                    }
                    else if (radioButton_fitr_gorn.Checked == true)
                    {
                        tmp = context.FiltrByTempLower_and_SortByTempAsc(prog, DateFilter, dateTimeFilter);
                    }

                }
                else if (radioButton_sort_mal.Checked == true)
                {
                    if (radioButton_filtr_dol.Checked == true)
                    {
                        tmp = context.FiltrByTempHigher_and_SortByTempDesc(prog, DateFilter, dateTimeFilter);
                    }
                    else if (radioButton_fitr_gorn.Checked == true)
                    {
                        tmp = context.FiltrByTempLower_and_SortByTempDesc(prog, DateFilter, dateTimeFilter);
                    }

                }

                else if (radioButton_filtr_dol.Checked == true && radioButton_sort_ros.Checked == false && radioButton_sort_mal.Checked == false)
                {

                    tmp = context.FiltrByTempHigher(prog, DateFilter, dateTimeFilter);
                }
                else if (radioButton_fitr_gorn.Checked == true && radioButton_sort_ros.Checked == false && radioButton_sort_mal.Checked == false)
                {
                    tmp = context.FiltrByTempLower(prog, DateFilter, dateTimeFilter);
                }


            }
            else
            {
               // && radioButton_fitr_gorn.Checked == false && radioButton_filtr_dol.Checked == false

                if (radioButton_sort_ros.Checked == true)
                {

                    tmp = context.SortByTempAsc(DateFilter, dateTimeFilter);

                }
                else if (radioButton_sort_mal.Checked == true)
                {
                    tmp = context.SortByTempDesc(DateFilter, dateTimeFilter);
                }
                else
                {
                    if (!DateFilter)
                    {
                        tmp = context.BazaPogodowa.ToList();
                    }
                    else
                    {
                        tmp = context.BazaPogodowa.Where(t => t.aktualnaDataCzas.Date == dateTimeFilter.Date).ToList();
                    }
                }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label3.Visible = true;
                dateTimePicker1.Visible = true;
                DateFilter = true;
               
            }
            else
            {
                DateFilter = false;      
                label3.Visible = false;
                dateTimePicker1.Visible = false;
            }
        }
    }
}
