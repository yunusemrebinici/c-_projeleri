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
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace Bankamatik
{
    public partial class FrmKayıt : Form
    {
        public FrmKayıt()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=DbBanka;Integrated Security=True;");

        private void FrmKayıt_Load(object sender, EventArgs e)
        {

        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            decimal d = 0;
            bgl.Open();
            SqlCommand ekle = new SqlCommand("INSERT INTO TBLKISILER (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)",bgl);
            ekle.Parameters.AddWithValue("@p1",TxtAd.Text);
            ekle.Parameters.AddWithValue("@p2",TxtSoyAd.Text);
            ekle.Parameters.AddWithValue("@p3",MskTc.Text);
            ekle.Parameters.AddWithValue("@p4",MskTel.Text);
            ekle.Parameters.AddWithValue("@p5",MskHesap.Text);
            ekle.Parameters.AddWithValue("@p6",TxtSifre.Text);
            ekle.ExecuteNonQuery();
            bgl.Close();
            bgl.Open();
            SqlCommand ekle2 = new SqlCommand("INSERT INTO TBLHESAP (HESAPNO,BAKIYE) values (@p1,@p2)",bgl);
            ekle2.Parameters.AddWithValue("@p1",MskHesap.Text);
            ekle2.Parameters.AddWithValue("@p2",d);
            ekle2.ExecuteNonQuery();          
            bgl.Close();
            MessageBox.Show("Kayıt Yapıldı");
        }
        int hesap;
        private void BtnHesapOlustur_Click(object sender, EventArgs e)
        {
            int arastır;
            Random rnd =new Random();
            hesap = rnd.Next(100000, 1000000);
            //hesap = 123455;
            bgl.Open();
            SqlCommand sorgu = new SqlCommand("select * from TBLKISILER  ", bgl);
            
            SqlDataReader dr= sorgu.ExecuteReader();
            while (dr.Read())
            {
                arastır = Convert.ToInt32(dr[5]);
                if (arastır==hesap)
                {
                    
                    MessageBox.Show("Sayı Daha önce atanmış");
                }
                else
                {
                    MskHesap.Text=hesap.ToString();
                }
            }
          
            
            bgl.Close();
            
            
        }
    }
}
