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
using System.Net.Configuration;

namespace proje6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl=new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=Proje6;Integrated Security=True;");
        private void Form1_Load(object sender, EventArgs e)
        {

            listele();
            


        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute Proje6", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void GbxÜrün_Enter(object sender, EventArgs e)
        {
            
        }

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            //ÜRÜN EKLEME
            bgl.Open();
            SqlCommand ekle = new SqlCommand(" INSERT INTO URUNLER (AD,STOK,ALISFIYAT,SATISFIYAT) values (@P1,@P2,@P3,@P4)", bgl);
            ekle.Parameters.AddWithValue("@P1", TxtUrunAd.Text);
            ekle.Parameters.AddWithValue("@P2", int.Parse(TxtStok.Text));
            ekle.Parameters.AddWithValue("@P3", int.Parse(TxtAlıs.Text));
            ekle.Parameters.AddWithValue("@P4", int.Parse(TxtSatıs.Text));
            ekle.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Ürün Ekleme İşlemi Gerçekleşti");
        }

        private void BtnMusteriEkle_Click(object sender, EventArgs e)
        {
            //Müşteri Ekleme
            bgl.Open();
            SqlCommand ekle = new SqlCommand("INSERT INTO MUSTERILER (ADSOYAD) VALUES (@P1)",bgl);
            ekle.Parameters.AddWithValue("@P1",TxtMusteri.Text);
            ekle.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Müşteri Ekleme İşlemi Başarı İle Gerçekleştirildi ");


        }

        private void BtnPerEkle_Click(object sender, EventArgs e)
        {
            //Personel Ekleme
            bgl.Open();
            SqlCommand ekle = new SqlCommand("INSERT INTO PERSONELLER (AD) VALUES (@P1)",bgl);
            ekle.Parameters.AddWithValue("@P1",TxtPerAd.Text);
            ekle.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Personel Ekleme İşlemi Gerlekleştirildi");
            
        }
       
        public void groupBox3_Enter(object sender, EventArgs e)
        {
            // Satış İşlemi
            
            //Ürün Adı Çekme
            SqlCommand urunler = new SqlCommand("Select * FROM URUNLER ", bgl);
            SqlDataAdapter u1= new SqlDataAdapter(urunler); 
            DataTable dturun= new DataTable();
            u1.Fill(dturun);
            CmbUrun.ValueMember = "ID";
            CmbUrun.DisplayMember = "AD";
            
            CmbUrun.DataSource = dturun;
            



            //MÜŞTERİ VERİ ÇEKME
            SqlCommand musteri = new SqlCommand("Select * FROM MUSTERILER ", bgl);
            SqlDataAdapter m1= new SqlDataAdapter(musteri);
            DataTable dtmüsteri = new DataTable();
            m1.Fill(dtmüsteri);
            CmbMusteri.ValueMember = "ID";
            CmbMusteri.DisplayMember = "ADSOYAD";  
            CmbMusteri.DataSource=dtmüsteri;

            //PERSONEL VERİ ÇEKME

            SqlCommand personel = new SqlCommand("Select * FROM PERSONELLER ", bgl);
            SqlDataAdapter p1=new SqlDataAdapter(personel);
            DataTable dtpersonel= new DataTable();  
            p1.Fill(dtpersonel);
            CmbPersonel.ValueMember= "ID";
            CmbPersonel.DisplayMember = "AD";
            CmbPersonel.DataSource=dtpersonel;
        }

        public void CmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {   bgl.Open();
                SqlCommand musteri = new SqlCommand("select SATISFIYAT FROM URUNLER WHERE ID=@P1",bgl);
                musteri.Parameters.AddWithValue("@P1",CmbUrun.SelectedValue);
                SqlDataReader dr = musteri.ExecuteReader();
                while (dr.Read())
                {
                    txtfiyat.Text = dr["SATISFIYAT"].ToString();
                }
                bgl.Close();
            }
            catch (Exception)
            {

               
            }
            
        }

        public void BtnSatis_Click(object sender, EventArgs e)
        {
            
            bgl.Open();
            SqlCommand ekle = new SqlCommand("INSERT INTO HARAKETLER (URUN,MUSTERI,PERSONEL,FIYAT) values (@P1,@P2,@P3,@P4)", bgl);
            ekle.Parameters.AddWithValue("@P1", CmbUrun.SelectedValue);
            ekle.Parameters.AddWithValue("@P2", CmbMusteri.SelectedValue);
            ekle.Parameters.AddWithValue("@P3", CmbPersonel.SelectedValue);
            ekle.Parameters.AddWithValue("@P4", txtfiyat.Text);
            ekle.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Satış Kaydı yapıldı");
            listele();
        }
    }
}
