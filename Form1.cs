using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ingilizce_Ogrenme
{
    public partial class Form1 : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Monster\source\repos\Ingilizce Ogrenme\dbSozluk.mdb");
        Random r = new Random();
        int sure = 120;
        int kelime = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        void data()
        {
            int sayi;
            sayi = r.Next(1, 2442);
            con.Open();
            OleDbCommand com = new OleDbCommand("Select * from sozluk where id = @p1", con);
            com.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                lblIng.Text = dr[1].ToString();
                lblCevap.Text = dr[2].ToString();
                lblCevap.Text = lblCevap.Text.ToLower();
            }
            con.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            data();
            timer1.Start();            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == lblCevap.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                data();
                textBox1.Clear();
            }
        }

        int pasHakkı = 5;
        private void button1_Click(object sender, EventArgs e)
        {
            data();
            pasHakkı--;
            lblPas.Text = pasHakkı.ToString();
            if (pasHakkı == 0)
           {
                btnPas.Enabled = false;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if(sure == 0)
            {
                timer1.Stop();
                textBox1.Enabled = false;
                MessageBox.Show("Süre bitti. Tebrikler! Tam " + kelime+ " adet kelimeyi doğru bildiniz.");
            }
        }
    }
}
