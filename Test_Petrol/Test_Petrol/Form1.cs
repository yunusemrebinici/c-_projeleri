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
using System.Collections;
using System.Net;

namespace Test_Petrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=TestBenzin;Integrated Security=True;");
        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            KASA();
            hesapla();
            istasyonalis();
        }
        void kasahesabı() 
        {
            double toplam;
            double b1, b2, b3, b4, b5; ;
            b1 = double.Parse(lblk95.Text) * double.Parse(a1.Text);
            b2= double.Parse(lblk97.Text) * double.Parse(a2.Text);
            b3 = double.Parse(lbld10.Text) * double.Parse(a3.Text);
            b4 = double.Parse(lblydizel.Text) * double.Parse(a4.Text);
            b5 = double.Parse(lblg.Text) * double.Parse(a5.Text);
            toplam= b1 + b2+b3+b4+b5;
            bgl.Open();
            SqlCommand cmd = new SqlCommand("update TBLKASA set MIKTAR=MIKTAR-@p1",bgl);
            cmd.Parameters.Add("@p1", toplam);
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show(toplam.ToString()+" "+"TL kasadan düşüldü");
        }
        void hesapla()
        {
            decimal depo = 10000;
            lblk95.Text = Convert.ToString( depo - Convert.ToDecimal(lbl1.Text));
            lblk97.Text = Convert.ToString(depo - Convert.ToDecimal(lbl2.Text));
            lbld10.Text = Convert.ToString(depo - Convert.ToDecimal(lbl3.Text));
            lblydizel.Text = Convert.ToString(depo - Convert.ToDecimal(lbl4.Text));
            lblg.Text = Convert.ToString(depo - Convert.ToDecimal(lbl5.Text));
        }
        void temizle() {
            TxtEuroDizelFiyat.Clear();
            TxtGazFiyat.Clear();
            TxtKursun95Fiyat.Clear();
            TxtKursun97Fiyat.Clear();
            TxtYenİDizelFiyat.Clear();
            TxtPlaka.Clear();

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
        }
        void KASA() 
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TBLKASA",bgl);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblKasa.Text = dr[0].ToString();
            }
            bgl.Close();
        }
        void istasyonalis() 
        {Dictionary<int,double> alisfiyat = new Dictionary<int,double>();
            for (int i = 1; i <=5; i++)
            {
                int key = i;
                bgl.Open();
                SqlCommand cmd = new SqlCommand("SELECT * from TBLBENZIN where ID=@p1",bgl);
                cmd.Parameters.AddWithValue("@p1",key);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    double fiyat =Convert.ToDouble( dr[2].ToString());
                    alisfiyat.Add(key,fiyat);
                }
                bgl.Close();   
                
            }
            a1.Text = alisfiyat[1].ToString();
            a2.Text = alisfiyat[2].ToString();
            a3.Text = alisfiyat[3].ToString();
            a4.Text = alisfiyat[4].ToString();
            a5.Text = alisfiyat[5].ToString();
        }
        void listele()
        {

           Dictionary <int,decimal> map=new Dictionary <int,decimal> ();
           Dictionary<int, double> depo = new Dictionary<int, double>();
            for (int s = 1; s <= 5; s++)
            {
                int a = s;
                bgl.Open();
                SqlCommand cmd = new SqlCommand("select * from TBLBENZIN where ID=@p1 ", bgl);
                cmd.Parameters.AddWithValue("@p1", a);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int key = a;
                    decimal value = Convert.ToDecimal(dr[3].ToString());
                    double benzin = Convert.ToDouble(dr[4].ToString());
                    map.Add(key,value);
                    depo.Add(key,benzin);
                    
                   
                }     
                bgl.Close();
            }
            LblKursun95.Text = map[1].ToString(); 
            LblKursun97.Text = map[2].ToString(); 
            LblDizel10.Text = map[3].ToString();  
            LblYeniDizel.Text= map[4].ToString(); 
            LblGaz.Text= map[5].ToString();

            pg95.Value = int.Parse(depo[1].ToString());
            pg97.Value = int.Parse(depo[2].ToString());
            pgeuro10.Value = int.Parse(depo[3].ToString());
            pgprodizel.Value = int.Parse(depo[4].ToString());
            pggaz.Value = int.Parse(depo[5].ToString());

            lbl1.Text = pg95.Value.ToString();
            lbl2.Text= pg97.Value.ToString();
            lbl3.Text=pgeuro10.Value.ToString();
            lbl4.Text=pgprodizel.Value.ToString();
            lbl5.Text=pggaz.Value.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, tutar,sonuc;
            kursunsuz95=Convert.ToDouble(LblKursun95.Text);
            tutar = Convert.ToDouble (numericUpDown1.Value);
            sonuc=kursunsuz95*tutar;
            

            TxtKursun95Fiyat.Text = sonuc.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, tutar, sonuc;
            kursunsuz97 = Convert.ToDouble(LblKursun97.Text);
            tutar = Convert.ToDouble(numericUpDown2.Value);
            sonuc = kursunsuz97 * tutar;

            TxtKursun97Fiyat.Text = sonuc.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double LblDizel, tutar, sonuc;
            LblDizel = Convert.ToDouble(LblDizel10.Text);
            tutar = Convert.ToDouble(numericUpDown3.Value);
            sonuc = LblDizel * tutar;

            TxtEuroDizelFiyat.Text = sonuc.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double yakit, tutar, sonuc;
            yakit = Convert.ToDouble(LblYeniDizel.Text);
            tutar = Convert.ToDouble(numericUpDown4.Value);
            sonuc = yakit * tutar;

            TxtYenİDizelFiyat.Text = sonuc.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double yakit, tutar, sonuc;
            yakit = Convert.ToDouble(LblGaz.Text);
            tutar = Convert.ToDouble(numericUpDown5.Value);
            sonuc = yakit * tutar;

            TxtGazFiyat.Text = sonuc.ToString();
        }

        private void BtnDoldur_Click(object sender, EventArgs e)
        {
            string petrol ="";
            double fiyat = 0;
            int litre = 0;
            string plakas = "";
            
            if (TxtKursun95Fiyat.Text!="" && TxtKursun95Fiyat.Text!="0")
            {
                petrol = "Kursunsuz95";
                plakas=TxtPlaka.Text;
                fiyat=Convert.ToDouble(TxtKursun95Fiyat.Text);
                litre =Convert.ToInt32(numericUpDown1.Value);
            }
            if (TxtKursun97Fiyat.Text!="" && TxtKursun97Fiyat.Text!="0")
            {
                petrol = "Kursunsuz97";
                plakas = TxtPlaka.Text;
                fiyat = Convert.ToDouble(TxtKursun97Fiyat.Text);
                litre = Convert.ToInt32(numericUpDown2.Value);
            }
            if (TxtEuroDizelFiyat.Text != "" && TxtEuroDizelFiyat.Text!="0")
            {
                petrol = "EuroDizel10";
                plakas = TxtPlaka.Text;
                fiyat = Convert.ToDouble(TxtEuroDizelFiyat.Text);
                litre = Convert.ToInt32(numericUpDown3.Value);
            }
            if (TxtYenİDizelFiyat.Text != "" && TxtYenİDizelFiyat.Text != "0")
            {
                petrol = "YeniProDizel";
                plakas = TxtPlaka.Text;
                fiyat = Convert.ToDouble(TxtYenİDizelFiyat.Text);
                litre = Convert.ToInt32(numericUpDown4.Value);
            }
            if (TxtGazFiyat.Text != "" && TxtGazFiyat.Text != "0")
            {
                petrol = "Gaz";
                plakas = TxtPlaka.Text;
                fiyat = Convert.ToDouble(TxtGazFiyat.Text);
                litre = Convert.ToInt32(numericUpDown5.Value);
            }

            if (fiyat!=0 && litre!=0 )
            {
                if (plakas!="")
                {
                    try
                    {
                        bgl.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO TBLHARAKETLER (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", bgl);
                        cmd.Parameters.AddWithValue("@p1", plakas);
                        cmd.Parameters.AddWithValue("@p2", petrol);
                        cmd.Parameters.AddWithValue("@p3", Convert.ToInt32(litre));
                        cmd.Parameters.AddWithValue("@p4", Convert.ToDecimal(fiyat));
                        cmd.ExecuteNonQuery();
                        bgl.Close();

                        bgl.Open();
                        SqlCommand cmd2 = new SqlCommand("update tblkasa set MIKTAR=MIKTAR+@P1",bgl);
                        cmd2.Parameters.AddWithValue("@P1",Convert.ToDecimal(fiyat));
                        cmd2.ExecuteNonQuery();
                        bgl.Close();
                        MessageBox.Show("Satış İşlemi Yapıldı");

                        bgl.Open();
                        SqlCommand cmd3 = new SqlCommand("update tblbenzın set STOK=STOK-@p2 where PETROLTUR=@p1",bgl);
                        cmd3.Parameters.AddWithValue("@p1",petrol);
                        cmd3.Parameters.AddWithValue("@p2",Convert.ToDecimal(litre));
                        cmd3.ExecuteNonQuery(); 
                        bgl.Close();
                        listele();
                        KASA();
                        temizle();
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Plaka Boş geçilemez");
                }
                
            }
            else
            {
                MessageBox.Show("Değerler boş olamaz");
            }
            hesapla();
        }
       
        private void TxtKursun95Fiyat_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value++;
            }
            kasahesabı();
            decimal full = 10000;
            bgl.Open();
            SqlCommand cmd = new SqlCommand("update TBLBENZIN set STOK =@P1",bgl); //bilerek where şartı koymadım 
            cmd.Parameters.AddWithValue("@P1",full);
            cmd.ExecuteNonQuery();
            bgl.Close();
            listele();
            hesapla();
            KASA();
            progressBar1.Value = 0;


            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
