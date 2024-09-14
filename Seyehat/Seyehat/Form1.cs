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

namespace Seyehat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=TestYolcuBilet;Integrated Security=True;");
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLYOLCUBILGI (AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl);
            cmd.Parameters.AddWithValue("@p1",TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2",TxtSoyAd.Text);
            cmd.Parameters.AddWithValue("@p3",MskTel.Text);
            cmd.Parameters.AddWithValue("@p4",MskTc.Text);
            cmd.Parameters.AddWithValue("@p5",CmbCinsiyet.Text);
            cmd.Parameters.AddWithValue("@p6",TxtMaıl.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Yolcu bilgileri kayıt edildi");
        }

        private void BtnKaptanKaydet_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLKAPTAN (KAPTANNO,ADSOYAD,TELEFON) VALUES (@p1,@p2,@p3)",bgl);
            cmd.Parameters.AddWithValue("@p1",TxtKaptanNo.Text);
            cmd.Parameters.AddWithValue("@p2",TxtKaptanAdS.Text);
            cmd.Parameters.AddWithValue("@p3",MskKaptanTelefon.Text);
            cmd.ExecuteNonQuery ();
            bgl.Close();
            MessageBox.Show("Kaptan kayıt edildi");
        }

        private void BtnSeferKaydet_Click(object sender, EventArgs e)
        {
            bgl.Open ();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLSEFERBILGI (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl);
            cmd.Parameters.AddWithValue("@p1",TxtKalkis.Text);
            cmd.Parameters.AddWithValue("@p2",TxtVaris.Text);
            cmd.Parameters.AddWithValue("@p3",MskTarih.Text);
            cmd.Parameters.AddWithValue("@p4",MskSaat.Text);
            cmd.Parameters.AddWithValue("@p5",MskKaptan.Text);
            cmd.Parameters.AddWithValue("@p6",TxtFiyat.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Kayıt İşlemi Başarı İle yapıldı");
            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            
        }
        public string tc;
        void seferlistele()
        {
            SqlCommand cmd = new SqlCommand("select * from TBLSEFERDETAY where YOLCUTC=@p1",bgl);
            cmd.Parameters.AddWithValue("@p1",tc);
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            DataTable da=new DataTable();
            dt.Fill(da);
            dataGridView2.DataSource = da;
            
        }
        void listele()
        {

            SqlDataAdapter dt = new SqlDataAdapter("select * from tblseferbılgı",bgl);
            DataTable da = new DataTable();
            dt.Fill(da);
            dataGridView1.DataSource = da;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            SeferNo2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtkoltuk.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtkoltuk.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtkoltuk.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtkoltuk.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtkoltuk.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtkoltuk.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtkoltuk.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtkoltuk.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtkoltuk.Text = "9";
        }

        private void BtnKaydetSefer2_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand CMD= new SqlCommand("INSERT INTO TBLSEFERDETAY (SEFERNO,YOLCUTC,KOLTUK) VALUES (@p1,@p2,@p3)",bgl);
            CMD.Parameters.AddWithValue("@p1",SeferNo2.Text);
            CMD.Parameters.AddWithValue("@p2",txtyolcutc.Text);
            CMD.Parameters.AddWithValue("@p3",txtkoltuk.Text);
            CMD.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Kayıt Yapıldı");
            tc=txtyolcutc.Text;
            if (tc!=null)
            {
                seferlistele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bgl.Open();
            SqlCommand cmd=new SqlCommand(" select * from TBLYOLCUBILGI where ID=@p1",bgl);
            cmd.Parameters.AddWithValue("@p1",txtyolcutc.Text);
            SqlDataReader dr= cmd.ExecuteReader();
            

                while (dr.Read())
                {
                   LblAd.Text = dr[1].ToString();
                   LblSoyAd.Text = dr[2].ToString();
                }

            if (LblAd.Text=="...")
            {
                MessageBox.Show("Hatalı ID");
            }
            else { txtkoltuk.Enabled = true; }
          
            bgl.Close();




        }
    }
}
