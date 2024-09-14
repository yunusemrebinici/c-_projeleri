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

namespace Rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl=new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=Rehber;Integrated Security=True;Encrypt=False");

        void listele() 
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("Select * From KISILER",bgl);
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataTable dt = new DataTable(); 
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            bgl.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand ekle = new SqlCommand("INSERT INTO KISILER (AD,SOYAD,TELEFON,MAIL,RESIM) VALUES (@p1,@p2,@p3,@p4,@p5)",bgl);
            ekle.Parameters.AddWithValue("@p1",TxtAd.Text);
            ekle.Parameters.AddWithValue("@p2",TxtSoy.Text);
            ekle.Parameters.AddWithValue("@p3",MskTel.Text);
            ekle.Parameters.AddWithValue("@p4",TxtMail.Text);
            ekle.Parameters.AddWithValue("@p5", TxtResimYol.Text);
            ekle.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Kayıt İşlemi Gerçekleşti");
            listele();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand guncelle = new SqlCommand("UPDATE KISILER SET AD=@p1,SOYAD=@p2,TELEFON=@p3,MAIL=@p4,RESIM=@p6  WHERE ID=@p5 ",bgl);
            guncelle.Parameters.AddWithValue("@p5",TxtId.Text);
            guncelle.Parameters.AddWithValue("@p1",TxtAd.Text);
            guncelle.Parameters.AddWithValue("@p2",TxtSoy.Text);
            guncelle.Parameters.AddWithValue("@p3",MskTel.Text);
            guncelle.Parameters.AddWithValue("@p4",TxtMail.Text);
            guncelle.Parameters.AddWithValue("@p6", TxtResimYol.Text);
            guncelle.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti");
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoy.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtResimYol.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            pictureBox1.ImageLocation = TxtResimYol.Text;
        }

        private void BtnTemızle_Click(object sender, EventArgs e)
        {
            TxtId.Clear(); TxtAd.Clear() ; TxtSoy.Clear() ;
            TxtMail.Clear() ; MskTel.Clear() ; TxtResimYol.Clear();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM KISILER WHERE ID=@p1 ",bgl);
            cmd.Parameters.AddWithValue("@p1",TxtId.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();    
            MessageBox.Show("Silme İşlemi Gerçekleşti");
            listele();

        }
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void BtnResim_Click(object sender, EventArgs e)
        {
            
             openFileDialog.ShowDialog();
             TxtResimYol.Text= openFileDialog.FileName;  

        }
    }
}
