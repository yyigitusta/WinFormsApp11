namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru, yanlýs;


        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            soruno++;
            if (soruno == 1)
            {
                button1.Text = "SONRAKÝ";
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                richTextBox1.Text = "Fatih Sultan Mehmet’in babasý kimdir?";
                button2.Text = "Yýldýrým Beyazýt";
                button3.Text = "I. Mehmet";
                button4.Text = "II. Murat";
                button5.Text = "Osman";
                label7.Text = "II. Murat";
                label6.Text = soruno.ToString();

            }
            if (soruno == 2)
            {
                button1.Text = "SONRAKÝ";
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                richTextBox1.Text = "Hangi yabancý futbolcu Fenerbahçe formasý giymiþtir?";
                button2.Text = "Schumacher";
                button3.Text = "Prekazi";
                button4.Text = "Simoviç";
                button5.Text = "Sota";
                label7.Text = "Schumacher";
                label6.Text = soruno.ToString();

            }
            if (soruno == 3)
            {
                button1.Text = "SONRAKÝ";
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                richTextBox1.Text = "Magna Carta hangi ülkenin kralýyla yapýlmýþ bir sözleþmedir?";
                button2.Text = "Ýngiltere";
                button3.Text = "Fransa";
                button4.Text = "Avusturya";
                button5.Text = "Fas";
                label7.Text = "Ýngiltere";
                button1.Text = "SON";
                label6.Text = soruno.ToString();
            }
            if (soruno == 4)
            {
                MessageBox.Show("DOÐRU SAYISI: " + dogru + "\n" + "YANLIÞ SAYISI: " + yanlýs);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == label7.Text)
            {
                dogru++;
                label2.Text = dogru.ToString();
                label4.Text = yanlýs.ToString();
            }
            else
            {
                yanlýs++;
                label2.Text = dogru.ToString();
                label4.Text = yanlýs.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == label7.Text)
            {
                dogru++;
                label2.Text = dogru.ToString();
                label4.Text = yanlýs.ToString();
            }
            else
            {
                yanlýs++;
                label2.Text = dogru.ToString();
                label4.Text = yanlýs.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == label7.Text)
            {
                dogru++;
                label2.Text = dogru.ToString();
                label4.Text = yanlýs.ToString();
            }
            else
            {
                yanlýs++;
                label2.Text = dogru.ToString();
                label4.Text = yanlýs.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == label7.Text)
            {
                dogru++;
                label2.Text = dogru.ToString();
                label4.Text = yanlýs.ToString();
            }
            else
            {
                yanlýs++;
                label2.Text = dogru.ToString();
                label4.Text = yanlýs.ToString();
            }
        }
    }
}