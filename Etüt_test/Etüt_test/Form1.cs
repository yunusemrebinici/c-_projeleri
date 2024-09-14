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
using System.Data.Common;
using System.Data.SqlTypes;

namespace Etüt_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=EtutTest;Integrated Security=True;");
        void Derslistele() 
        {
            SqlDataAdapter da= new SqlDataAdapter("select * from TBLDERSLER",bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbDers.ValueMember ="DERSID";
            CmbDers.DisplayMember ="DERSAD";
            CmbDers.DataSource = dt;
        }
        void Ogrlistele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLOGRENCI", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbOgrenci.ValueMember = "OGRID";
            CmbOgrenci.DisplayMember = "AD";
            CmbOgrenci.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Derslistele();
            listele();
            Ogrlistele();
        }
        void listele() 
        {
            bgl.Open();
            SqlDataAdapter da = new SqlDataAdapter ("Execute sorgu",bgl);
            DataTable dt=new DataTable();
            da.Fill (dt);
            dataGridView1.DataSource= dt;
            bgl.Close();
        }
       
        private void CmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLOGRETMEN WHERE BRANSID="+CmbDers.SelectedValue, bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbOgretmen.ValueMember = "OGRTID";
            CmbOgretmen.DisplayMember = "AD";
            CmbOgretmen.DataSource = dt;
        }

        private void BtnEtut_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd=new SqlCommand("INSERT INTO TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)",bgl);
            cmd.Parameters.AddWithValue("@p1",CmbDers.SelectedValue);
            cmd.Parameters.AddWithValue("@p2",CmbOgretmen.SelectedValue);
            cmd.Parameters.AddWithValue("@p3",MskTarih.Text);
            cmd.Parameters.AddWithValue("@p4",MskSaat.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("İşlem Başarılı");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            LblDersId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString() ;
        }
        
        private void BtnEtutDetay_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TBLETUT SET DURUM='True' , OGRENCIID=@p1 where ID=@p2 ",bgl);
            cmd.Parameters.AddWithValue("@p2",LblDersId.Text);
            cmd.Parameters.AddWithValue("@p1",CmbOgrenci.SelectedValue);
            cmd.ExecuteNonQuery (); bgl.Close();
            listele();
        }

        private void BtnDersEkle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLDERSLER (DERSAD) values (@p1)",bgl);
            cmd.Parameters.AddWithValue("@p1",TxtDersEkle.Text);
            cmd.ExecuteNonQuery(); bgl.Close();
            MessageBox.Show("Ders Eklendi");
            Derslistele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl);
            cmd.Parameters.AddWithValue("@p1",TxtOgrAdEkle.Text);
            cmd.Parameters.AddWithValue("@p2",TxtOgrSoyEkle.Text);
            cmd.Parameters.AddWithValue("@p3",LblFotoYol.Text);
            cmd.Parameters.AddWithValue("@p4",CmbSınıf.SelectedItem);
            cmd.Parameters.AddWithValue("@p5",MskOgrTelEkle.Text);
            cmd.Parameters.AddWithValue("@p6",RchMail.Text);
            cmd.ExecuteNonQuery();bgl.Close();
            MessageBox.Show("Öğrenci Kayıt Edildi");
            Ogrlistele();
        }

        private void CmbSınıf_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BtnFotograf_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            LblFotoYol.Text = ofd.FileName;
            pictureBox1.ImageLocation = LblFotoYol.Text;
        }

        private void BtnOgrtEkle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLOGRETMEN (AD,SOYAD,BRANSID) VALUES (@p1,@p2,@p3)",bgl);
            cmd.Parameters.AddWithValue("@p1",TxtHocaEkle.Text);
            cmd.Parameters.AddWithValue("@p2",TxtHocaSoyad.Text);
            cmd.Parameters.AddWithValue("@p3",CmbBrans.SelectedValue);
            cmd.ExecuteNonQuery();
            bgl.Close();
            Ogrlistele();
            
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLDERSLER", bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbBrans.ValueMember = "DERSID";
            CmbBrans.DisplayMember = "DERSAD";
            CmbBrans.DataSource = dt;
        }

        private void CmbOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bgl.Open();
                string query = "SELECT FOTOGRAF FROM TBLOGRENCI WHERE OGRID = @ogrid";
                SqlCommand cmd = new SqlCommand(query, bgl);
                cmd.Parameters.AddWithValue("@ogrid", CmbOgrenci.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() && dr[0] != DBNull.Value) // Veri tabanından dönen değerin boş olup olmadığını kontrol ediyoruz
                {
                    LblFotoYol2.Text = dr[0].ToString(); // Fotoğraf yolunu label'a ekliyoruz
                    pictureBox2.ImageLocation = LblFotoYol2.Text; // Fotoğrafı PictureBox'ta gösteriyoruz
                }
                else
                {
                    pictureBox2.ImageLocation=null;
                }


                bgl.Close();
            }
            catch (Exception)
            {

                
            }
           
           





            //if (dr.Read()==true)
            //{
            //     LblFotoYol.Text = dr[0].ToString();
            //     pictureBox2.ImageLocation = LblFotoYol.Text;
            //}
            
        }

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}
	}
}
