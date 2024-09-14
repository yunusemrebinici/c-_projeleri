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

namespace Test_Trigger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=TEST;Integrated Security=True;");
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            kitapsayisi();
        }

        void listele() 
        
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLKITAPLAR",bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void kitapsayisi() 
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("select * from TBLSAYAC", bgl);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblKitapSayısı.Text = dr[0].ToString();
            }
            bgl.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand ekle = new SqlCommand("INSERT INTO tblkıtaplar (AD,YAZAR,SAYFA,YAYINEVI,TUR) values (@p1,@p2,@p3,@p4,@p5) ",bgl);
            ekle.Parameters.AddWithValue("@p1",TxtAd.Text);
            ekle.Parameters.AddWithValue("@p2",TxtYazar.Text);
            ekle.Parameters.AddWithValue("@p3",TxtSayfa.Text);
            ekle.Parameters.AddWithValue("@p4",TxtYayınEvi.Text);
            ekle.Parameters.AddWithValue("@p5",TxtTur.Text);
            ekle.ExecuteNonQuery();
            bgl.Close();
            listele();
            kitapsayisi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSayfa.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtYayınEvi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtTur.Text=dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("delete from tblkıtaplar where ID=@p1 ",bgl);
            cmd.Parameters.AddWithValue("@p1",TxtId.Text);
            cmd.ExecuteNonQuery();
            bgl.Close();
            listele();
            kitapsayisi();

        }
    }
}
