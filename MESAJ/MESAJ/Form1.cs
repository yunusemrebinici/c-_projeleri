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

namespace MESAJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=MESAJ;Integrated Security=True;");
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("Select * From KISILER where AD=@P1 AND SIFRE=@P2",bgl);
            cmd.Parameters.AddWithValue("@P1",TxtKullanıcıAd.Text);
            cmd.Parameters.AddWithValue("@P2",TxtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
           
            if (dr.Read())
            {
                FrmMesaj frmMesaj = new FrmMesaj();
                this.Hide();
                frmMesaj.ad = dr[1] + " "+ dr[2].ToString();
                frmMesaj.kullanıcıadı = int.Parse(dr[3].ToString());
                frmMesaj.sifre = int.Parse(dr[4].ToString());
                frmMesaj.Show();
            }
            else
            {
                MessageBox.Show("Yanlış Şifre");
            }
            bgl.Close();

        }
    }
}
