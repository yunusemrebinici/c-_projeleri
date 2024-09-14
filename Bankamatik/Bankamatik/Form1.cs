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

namespace Bankamatik
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

        private void LnkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmKayıt fr = new FrmKayıt();
            fr.Show();
        }
        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=DbBanka;Integrated Security=True;");
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                bgl.Open();
                SqlCommand s = new SqlCommand("Select * from TBLKISILER WHERE HESAPNO=@P1 and SIFRE=@P2 ", bgl);
                s.Parameters.AddWithValue("@P1", TxtHesapNo.Text);
                s.Parameters.AddWithValue("@P2", TxtSifre.Text);
                SqlDataReader dr = s.ExecuteReader();
                while (dr.Read())
                {
                    FrmHesap frm = new FrmHesap();
                    frm.ad = dr[1]+" "+dr[2].ToString();
                    frm.hesapno = dr[5].ToString();
                    frm.telefon = dr[4].ToString();
                    frm.tc = dr[3].ToString();
                    frm.Show();
                    
                }
                bgl.Close();
                
              
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı Adı ve Şifre Hatalı");
            }
           
        }
    }
}
