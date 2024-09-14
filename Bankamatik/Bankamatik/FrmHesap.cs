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
    public partial class FrmHesap : Form
    {
        public FrmHesap()
        {
            InitializeComponent();
        }
        public string ad;
        public string hesapno;
        public string telefon;
        public string tc;
        private void FrmHesap_Load(object sender, EventArgs e)
        {
            LblAdSoyad.Text=ad;
            LblHesapNo.Text=hesapno;
            LblTelefon.Text=telefon;
            LblTc.Text=tc;
            
        }
        SqlConnection bgl = new SqlConnection("Data Source=EMRE\\SQLEXPRESS01;Initial Catalog=DbBanka;Integrated Security=True;");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            //Gönderilen hesabın para artışı
            bgl.Open();
            SqlCommand kmt = new SqlCommand("update tblhesap set BAKIYE=BAKIYE+@p1 where HESAPNO=@p2",bgl);
            kmt.Parameters.AddWithValue("@p1",decimal.Parse(TxtTutar.Text));
            kmt.Parameters.AddWithValue("@p2",MskHesapNo.Text);
            kmt.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Gönderme Başarılı");

            //Gönderen hesabın para azalışı
            bgl.Open();
            SqlCommand kmt2 = new SqlCommand("update tblhesap set BAKIYE=BAKIYE-@p1 where HESAPNO=@p2",bgl);
            kmt2.Parameters.AddWithValue("@p1",decimal.Parse(TxtTutar.Text));
            kmt2.Parameters.AddWithValue("@p2",hesapno);
            kmt2.ExecuteNonQuery();
            bgl.Close();

            //HARAKET TABLOSUNA VERİLERİN EKLENMESİ
            bgl.Open();
            SqlCommand kmt3 = new SqlCommand("INSERT INTO TBLHARAKET (GONDEREN,ALICI,TUTAR) values (@p1,@p2,@p3)",bgl);
            kmt3.Parameters.AddWithValue("@p1",hesapno);
            kmt3.Parameters.AddWithValue("@p2",MskHesapNo.Text);
            kmt3.Parameters.AddWithValue("@p3",decimal.Parse(TxtTutar.Text));
            kmt3.ExecuteNonQuery();

            bgl.Close();
        }

        private void BtnHaraketler_Click(object sender, EventArgs e)
        {
            FrmHaraketler fr =new FrmHaraketler();
            fr.ghesap=hesapno;
            fr.ahesap = MskHesapNo.Text;
            fr.Show();
        }
    }
}
