using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Kelime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn=new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=Sozluk;Integrated Security=True;");
        Random rand = new Random();

        void getir() {

            int sayi = rand.Next(1, 11);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from SOZLUK where ID=@P1 ", conn);
            cmd.Parameters.AddWithValue("@P1", sayi);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Txting.Text = reader[1].ToString();
                LblKontrol.Text = reader[2].ToString().ToLower();
                
               
            }
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           getir();
            timer1.Start();
            LblAd.Text = ad;
        }
        int sayac = 0;
        int sure = 9;
        private void TxtTurkce_TextChanged(object sender, EventArgs e)
        {

            if (TxtTurkce.Text==LblKontrol.Text)
            {
                sayac++;
                LblDogru.Text=sayac.ToString();
                getir();
                TxtTurkce.Clear();
                sure=9;
            }
            
        }
        public string ad;
        public int sifre;
        void dogrukayıt() 
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update UYE set Dogru=@p1 where AdSoyad=@p2 and Sıfre=@p3", conn);
            cmd.Parameters.AddWithValue("@p1", sayac);
            cmd.Parameters.AddWithValue("@p2",ad);
            cmd.Parameters.AddWithValue("@p3",sifre);
            cmd.ExecuteNonQuery();
            conn.Close();
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSure.Text = sure.ToString();
            if (sure==0)
            {
                dogrukayıt();
                Txting.Enabled = false;
                TxtTurkce.Enabled = false;
                timer1.Stop();
                MessageBox.Show("Süreniz bitti ,doğru sayınız : " + sayac.ToString());

            }
        }
    }
}
