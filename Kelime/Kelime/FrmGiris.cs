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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=Sozluk;Integrated Security=True;");
        private void FrmGiris_Load(object sender, EventArgs e)
        {
          
        }

        private void Giris_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from UYE where AdSoyad=@p1 and Sıfre=@p2",conn);
            cmd.Parameters.AddWithValue("@p1",TxtAd.Text.ToUpper());
            cmd.Parameters.AddWithValue("@p2",TxtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()==true)
            {
                Form1 fr = new Form1();
                
                fr.ad = dr[1].ToString();
                fr.sifre = int.Parse(dr[2].ToString());
                fr.Show();
                this.Hide();
               
                
            }

            conn.Close();
          
        }
    }
}
